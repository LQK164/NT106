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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week3
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        private Socket UDPClient;
        private bool connecting = true;
        private Thread thrdUDPClient;
        delegate void ClearCachedReceivedData(string data, IPAddress ipaddr);

        private void Connect_Click(object sender, EventArgs e)
        {
            UDPClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            UDPClient.Bind(new IPEndPoint(IPAddress.Any, 9091));
            thrdUDPClient = new Thread(new ThreadStart(ClientThread));
            thrdUDPClient.Start();
            this.Connect.Enabled = false;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            IPEndPoint remote = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
            EndPoint server_endpoint = (EndPoint)remote;
            byte[] message = Encoding.UTF8.GetBytes(Message_Box.Text);
            try
            {
                UDPClient.SendTo(message, server_endpoint);
                ChatBox.Items.Add($"Client: {Encoding.UTF8.GetString(message)}");
                Message_Box.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Failed! Please send again.", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChatBox.Items.Add($"Client: {Encoding.UTF8.GetString(message)}");
            }
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
                string message = $"Server: {data}";
                ChatBox.Items.Add(message);
            }
        }

        private void ClientThread()
        {
            IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
            EndPoint serverEndpoint = (EndPoint)remote;
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024];
                    int length = UDPClient.ReceiveFrom(data, ref serverEndpoint);
                    string message = Encoding.UTF8.GetString(data, 0, length);
                    ReceiveData(message, remote.Address);
                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            ChatBox.Items.Add("Server: " + message);
                        }));
                    }   
                    else
                    {
                        ChatBox.Items.Add("Server: " + message);
                    }    
                }

                catch
                {
                    MessageBox.Show("Failed! Please connect again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    thrdUDPClient.Start();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
