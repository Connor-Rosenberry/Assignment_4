using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Security.Cryptography;

namespace SmpServer
{
    public partial class FormSmpServer : Form
    {
        private TcpListener server;
        private Thread serverThread;
        private bool isRunning = false;
        private static readonly string messageFile = "messages.txt"; // File to store messages

        // RSA Key Variables
        private RSACryptoServiceProvider rsa;
        private string publicKey;
        private string privateKey;

        public FormSmpServer()
        {

            // Generate RSA Key Pair
            rsa = new RSACryptoServiceProvider(2048);
            publicKey = rsa.ToXmlString(false); // Public Key (for encryption)
            privateKey = rsa.ToXmlString(true); // Private Key (for decryption)
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;

                serverThread = new Thread(StartServer);
                serverThread.IsBackground = true; // Ensures it stops when the app closes
                serverThread.Start();
                MessageBox.Show("Server started!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Server is already running!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowMessages_Click(object sender, EventArgs e)
        {
            if (File.Exists(messageFile))
            {
                string[] messages = File.ReadAllLines(messageFile, Encoding.UTF8);
                Message_display.Items.Clear(); // Assuming you have a ListBox named listBoxMessages

                foreach (string message in messages)
                {
                    Message_display.Items.Add(message);
                }
            }
            else
            {
                MessageBox.Show("No messages found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 5000);
                server.Start();
                while (isRunning)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleClient(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                string response = ProcessMessage(message);
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error getting message", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                client.Close();
            }
        }

        private string DecryptMessage(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, false);
            string decryptedMessage = Encoding.UTF8.GetString(decryptedBytes);

            MessageBox.Show("recevied decrypted message", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return "Message received!";
        }

        private string ProcessMessage(string request)
        {
            if (request == "GET_PUBLIC_KEY")
            {
                return rsa.ToXmlString(false); // Send public key to client
            }
            if (request.StartsWith("PUT:"))
            {
                string message = request.Substring(4);
                try
                {
                    File.AppendAllText(messageFile, message + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    return $"Error saving message: {ex.Message}";
                }

                return "Message stored successfully!";
            }
            else if (request.StartsWith("GET"))
            {
                if (File.Exists(messageFile))
                {
                    string[] messages = File.ReadAllLines(messageFile);
                    if (messages.Length > 0)
                    {
                        string firstMessage = messages[0];

                        // Rewrite file without the first message (Compatible with older C#)
                        using (StreamWriter writer = new StreamWriter(messageFile))
                        {
                            for (int i = 1; i < messages.Length; i++)
                            {
                                writer.WriteLine(messages[i]);
                            }
                        }

                        return $"Message: {firstMessage}";
                    }
                }
                return "No messages available.";
            }
            return "Invalid request.";
        }
    }
}
