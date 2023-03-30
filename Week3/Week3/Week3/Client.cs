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

namespace Week3
{
    public partial class Client : Form
    {
        private UdpClient udpClient;
        private IPEndPoint serverEndpoint;
        public Client()
        {
            InitializeComponent();
            udpClient = new UdpClient(new IPEndPoint(IPAddress.Any, 9091));
            serverEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string message = Message_Box.Text;
            byte[] data = Encoding.UTF8.GetBytes(message);
            udpClient.Send(data, data.Length, serverEndpoint);
            ChatBox.Items.Add("Client: " + message);
            Message_Box.Clear();
        }

        private void Receive()
        {
            while (true)
            {
                try
                {
                    IPEndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = udpClient.Receive(ref remoteEndpoint);
                    string message = Encoding.UTF8.GetString(data);
                    Invoke(new Action(() =>
                    {
                        ChatBox.Items.Add("Server:" + message);
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            serverEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
            Thread receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.Start();
        }
    }
}
