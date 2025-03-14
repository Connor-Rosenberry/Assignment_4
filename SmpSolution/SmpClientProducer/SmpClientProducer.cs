using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpClientProducer
{
    public partial class FormSmpClientProducer : Form
    {
        private string publicKeyXml;
        private int selectedPriority = 0; // Default to Low

        public FormSmpClientProducer()
        {
            InitializeComponent();

            IP_Input.Text = "127.0.0.1";  // Default IP
            Port_Input.Text = "50400";    // Default Port
        }

        private string GetServerIP()
        {
            return string.IsNullOrWhiteSpace(IP_Input.Text) ? "127.0.0.1" : IP_Input.Text;
        }

        private int GetPortNumber()
        {
            if (int.TryParse(Port_Input.Text, out int port))
            {
                return port;
            }
            return 50400; // Default port if input is invalid
        }

        public void Connect()
        {
            string serverIP = GetServerIP();
            int port = GetPortNumber();
            try
            {
                using (TcpClient client = new TcpClient(serverIP, port))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] requestBytes = Encoding.UTF8.GetBytes("GET_PUBLIC_KEY");
                    stream.Write(requestBytes, 0, requestBytes.Length);

                    byte[] buffer = new byte[4096];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    publicKeyXml = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    if (!string.IsNullOrEmpty(publicKeyXml))
                    {
                        MessageBox.Show("Public key received successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Public key is empty! Check server logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to server: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(publicKeyXml))
            {
                Connect(); // 🔹 Automatically get public key if not connected
            }

            int priority = selectedPriority;
            if (priority == -1)
            {
                MessageBox.Show("Please select a priority before sending the message.", "Priority Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string timestamp = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
            string message = Text_Message.Text.Trim(); // Get user input

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please enter a message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Encrypt message using RSA
            string encryptedMessage = EncryptMessageRSA(message);

            // Combine unencrypted and encrypted parts
            string smpPutPacket = $"Version_1_0\n{priority}\n{timestamp}\n{encryptedMessage}";


            // Send the encrypted message to the SMP Server
            SendMessageToServer(smpPutPacket);
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            selectedPriority = 0;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            selectedPriority = 1;
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            selectedPriority = 2;
        }

        private string EncryptMessageRSA(string plainText)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(publicKeyXml); // Set public key

                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plainText), false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        private void SendMessageToServer(string smpPutPacket)
        {
            string serverIP = GetServerIP();
            int port = GetPortNumber();
            try
            {
                using (TcpClient client = new TcpClient(serverIP, port))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] data = Encoding.UTF8.GetBytes("PUT: " + smpPutPacket); // Ensure correct command format
                    stream.Write(data, 0, data.Length);

                    // Read response from server
                    byte[] responseBuffer = new byte[1024];
                    int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                    string response = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);
                    
                    // Display server response in UI
                    Invoke(new Action(() => Server_Response.Text = response));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Text_Message_TextChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Container_Enter(object sender, EventArgs e)
        {

        }
    }
}
