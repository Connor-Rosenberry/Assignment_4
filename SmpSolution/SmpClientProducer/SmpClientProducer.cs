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
        private readonly string serverIP = "127.0.0.1"; // Change to actual server IP
        private readonly int serverPort = 5000; // Define the port the server listens on
        private string publicKeyXml;

        public FormSmpClientProducer()
        {
            InitializeComponent();
        }

        public void Connect()
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIP, serverPort))
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

            string message = Text_Message.Text; // User input

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please enter a message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Encrypt message using RSA
            string encryptedMessage = EncryptMessageRSA(message);

            // Send the encrypted message to the SMP Server
            SendMessageToServer(encryptedMessage);
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

        private void SendMessageToServer(string encryptedMessage)
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIP, serverPort))
                using (NetworkStream stream = client.GetStream())
                {
                    string request = "PUT:" + encryptedMessage; // Ensure correct format
                    byte[] data = Encoding.UTF8.GetBytes(request);
                    stream.Write(data, 0, data.Length);
                }
                MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
