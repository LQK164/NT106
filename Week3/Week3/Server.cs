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

namespace Week3
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        private UdpClient UDPServer;
        private bool listening = true;
        private Thread thrdUDPServer;
        delegate void ClearCachedReceivedData(string data, IPAddress ipaddr);

        private void Server_Load(object sender, EventArgs e)
        {
            UDPServer = new UdpClient(11000);
            thrdUDPServer = new Thread(new ThreadStart(ServerThread));
            thrdUDPServer.Start();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.UTF8.GetBytes(Message_Box.Text);
            UDPServer.Send(message, message.Length, "192.168.0.104", 11001);
            ChatBox.Items.Add($"Server: {Encoding.UTF8.GetString(message)}");
            Message_Box.Text = string.Empty;
        }

        private void ReceiveData(string data, IPAddress ipaddr)
        {
            if (ChatBox.InvokeRequired)
            {
                var method = new ClearCachedReceivedData(ReceiveData);
                ChatBox.Invoke(method, new object[] { data, ipaddr });
            }
            else
            {
                string message = $"Client: {data}";
                ChatBox.Items.Add(message);
            }
        }

        private void ServerThread()
        {
            IPEndPoint clientEndpoint = new IPEndPoint(IPAddress.Parse("192.168.0.104"), 11000);
            while (listening)
            {
                try
                {
                    byte[] data = new byte[1024];
                    data = UDPServer.Receive(ref clientEndpoint);
                    string message = Encoding.UTF8.GetString(data);
                    ReceiveData(message, clientEndpoint.Address);
                }
                catch
                {
                    MessageBox.Show("Failed! Please send again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    thrdUDPServer.Abort();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
