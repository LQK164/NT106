using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Server
{
    public partial class Server : Form
    {
        private UdpClient udpServer;
        private bool listening = true;
        private Thread serverThread;
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            try
            {
                udpServer = new UdpClient(9090);
                serverThread = new Thread(new ThreadStart(ServerThread));
                serverThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize UDP server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SEND_Click(object sender, EventArgs e)
        {
            try
            {
                string message = Message_Box.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                IPEndPoint clientEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9091);

                if (udpServer != null)
                {
                    udpServer.Send(data, data.Length, clientEndpoint);
                    ChatBox.Items.Add("Server: " + message);
                    Message_Box.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed! Please send again. " + ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReceiveData(string data, IPEndPoint endpoint)
        {
            if (ChatBox.InvokeRequired)
            {
                var method = new Action<string, IPEndPoint>(ReceiveData);
                Invoke(method, new object[] { data, endpoint });
            }
            else
            {
                ChatBox.Items.Add("Client :" + data);
            }
        }

        private void ServerThread()
        {
            IPEndPoint clientEndpoint = new IPEndPoint(IPAddress.Any, 0);
            while (listening)
            {
                try
                {
                    byte[] data = udpServer.Receive(ref clientEndpoint);
                    string message = Encoding.UTF8.GetString(data);
                    ReceiveData(message, clientEndpoint);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to receive data. " + ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Message_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}