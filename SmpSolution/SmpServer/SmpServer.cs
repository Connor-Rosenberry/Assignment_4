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

            // Set default values for IP and Port inputs
            Address_input.Text = "127.0.0.1";
            Port_Input.Text = "50400";
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

        private void DisplayMessages(int priorityFilter)
        {
            if (!File.Exists(messageFile))
            {
                MessageBox.Show("No messages available.");
                return;
            }

            // Clear the text box before displaying new messages
            Message_display.Clear();

            // Read all messages
            string[] messages = File.ReadAllLines(messageFile);
            List<string> filteredMessages = new List<string>();

            for (int i = 0; i < messages.Length; i += 4) // Assuming 4 lines per message
            {
                if (i + 3 < messages.Length)
                {
                    if (int.TryParse(messages[i + 1].Trim(), out int messagePriority))
                    {
                        string version = messages[i].Trim();       // First line (Version)
                        string timestamp = messages[i + 2].Trim(); // Third line (Timestamp)
                        string messageContent = messages[i + 3].Trim(); // Fourth line (Encrypted Message)

                        // Add messages that match the selected priority or show all if -1
                        if (priorityFilter == 3 || messagePriority == priorityFilter)
                        {
                            // Append the full multiline format
                            filteredMessages.Add($"{version}\n{messagePriority}\n{timestamp}\n{messageContent}");
                        }
                    }
                }
            }

            // Display only the selected messages
            if (filteredMessages.Count > 0)
            {
                Message_display.Text = string.Join("\n\n", filteredMessages); // Separate each message with a blank line
            }
            else
            {
                Message_display.Text = "No messages found for the selected priority.";
            }
        }




        private void btnShowMessages_Click(object sender, EventArgs e)
        {
            DisplayMessages(3); // Show all messages, using the same logic as the filtering function
        }

        private string GetServerIP()
        {
            if (string.IsNullOrWhiteSpace(Address_input.Text))
            {
                return "127.0.0.1";  // Default IP if the input is empty
            }
            return Address_input.Text.Trim();
        }

        private int GetPortNumber()
        {
            if (int.TryParse(Port_Input.Text, out int port) && port > 1024 && port < 65535)
            {
                return port;  // Use the user-provided port
            }
            return 50400;  // Default to 50400 if input is invalid
        }

        private void StartServer()
        {
            string serverIP = GetServerIP();  // Get user-defined IP or default
            int port = GetPortNumber();       // Get user-defined port or default
            try
            {
                // Reset message storage file when server starts
                File.WriteAllText(messageFile, string.Empty); // Clears the file

                IPAddress ipAddress = IPAddress.Parse(serverIP);
                server = new TcpListener(ipAddress, port);
                server.Start();
                isRunning = true;

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

        private string ProcessMessage(string request)
        {
            if (request == "GET_PUBLIC_KEY")
            {
                return rsa.ToXmlString(false); // Send public key to client
            }
            if (request.StartsWith("PUT:"))
            {
                string[] messageParts = request.Substring(4).Trim().Split('\n'); // Remove "PUT:" and split linesspaces

                string smpVersion = messageParts[0];    // "Version_1_0"
                string messagePriority = messageParts[1]; // "0", "1", or "2"
                string messageDate = messageParts[2];
                string messageContent = messageParts[3]; // Actual message content

                try
                {
                    string messageData = string.Join(Environment.NewLine, smpVersion, messagePriority, messageDate, messageContent);
                    File.AppendAllText(messageFile, messageData + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    return $"Error saving message: {ex.Message}";
                }

                this.Invoke((MethodInvoker)delegate
                {
                    txtMessageType.Text = "PUT";
                    txtMessagePriority.Text = messagePriority;
                });

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

        private void BtnLow_Click(object sender, EventArgs e)
        {
            DisplayMessages(0);
        }

        private void BtnMedium_Click(object sender, EventArgs e)
        {
            DisplayMessages(1);
        }

        private void BtnHigh_Click(object sender, EventArgs e)
        {
            DisplayMessages(2);
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            DisplayMessages(3);
        }

        private void Messages_Container_Enter(object sender, EventArgs e)
        {

        }

        private void Message_display_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Address_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
