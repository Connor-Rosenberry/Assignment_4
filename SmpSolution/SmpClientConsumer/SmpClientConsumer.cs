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
        private const string serverIP = "127.0.0.1"; // Change if needed
        private const int serverPort = 5000;         // Ensure this matches the server

        public FormSmpClientConsumer()
        {
            InitializeComponent();
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIP, serverPort))
                using (NetworkStream stream = client.GetStream())
                {
                    // Send SMP GET request
                    string getRequest = "SMP_GET:Priority=1";
                    byte[] requestData = Encoding.UTF8.GetBytes(getRequest);
                    stream.Write(requestData, 0, requestData.Length);

                    // Receive response from server
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string encryptedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Decrypt the message
                    string decryptedMessage = DecryptMessage(encryptedMessage);
                    MessageBox.Show("Received Message:\n" + decryptedMessage, "SMP Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    rsa.FromXmlString(System.IO.File.ReadAllText("private_key.xml"));

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
    }
}
