using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpClientConsumer
{
    public partial class FormSmpClientConsumer : Form
    {
        private int selectedPriority = 0; // Default to Low
        private string privateKeyXml;
        public FormSmpClientConsumer()
        {
            InitializeComponent();

            IP_Input.Text = "127.0.0.1";  // Default IP
            Port_Input.Text = "50400";    // Default Port
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
                    byte[] requestBytes = Encoding.UTF8.GetBytes("GET_PRIVATE_KEY");
                    stream.Write(requestBytes, 0, requestBytes.Length);

                    byte[] buffer = new byte[4096];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    privateKeyXml = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    if (!string.IsNullOrEmpty(privateKeyXml))
                    {
                        // Save private key to file for later use
                        System.IO.File.WriteAllText("private_key.xml", privateKeyXml);
                        MessageBox.Show("Private key received and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Private key is empty! Check server logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to server: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            // Make sure we have the private key before getting messages
            if (string.IsNullOrEmpty(privateKeyXml))
            {
                Connect(); // Try to get private key if we don't have it
                if (string.IsNullOrEmpty(privateKeyXml))
                {
                    MessageBox.Show("Cannot get messages without private key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                using (TcpClient client = new TcpClient(GetServerIP(), GetPortNumber()))
                using (NetworkStream stream = client.GetStream())
                {
                    // Send SMP GET request
                    string getRequest = "GET:" + selectedPriority.ToString();
                    byte[] requestData = Encoding.UTF8.GetBytes(getRequest);
                    stream.Write(requestData, 0, requestData.Length);
                    // Receive response from server
                    byte[] buffer = new byte[4096];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    if (response.StartsWith("Message:"))
                    {
                        string encryptedMessage = response.Substring(8).Trim();
                        string[] messageParts = encryptedMessage.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                        // Get the header (first 3 lines)
                        string headerInfo = string.Join("\n", messageParts.Take(3));
                        //MessageBox.Show($"{headerInfo}", "SMP Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Get the encrypted content (remaining lines)
                        string encryptedContent = string.Join("\n", messageParts.Skip(3));

                        string decryptedMessage = DecryptMessage(encryptedContent);
                        //MessageBox.Show("Received Message:\n" + decryptedMessage, "SMP Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Text_Message.Items.Add(decryptedMessage);
                    }
                    else
                    {
                        MessageBox.Show(response, "SMP Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error receiving message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string DecryptMessage(string encryptedText)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    // Load Private Key (This should be securely stored)
                    rsa.FromXmlString(privateKeyXml);

                    byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                    byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, false);
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
            catch (Exception ex)
            {
                return $"Decryption Error: {ex.Message}";
            }
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
    }
}
