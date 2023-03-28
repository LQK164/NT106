using System.Runtime.Intrinsics.X86;

namespace Week3
{
    public partial class udp_chat : Form
    {
        public udp_chat()
        {
            InitializeComponent();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            Server myForm = new Server();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client myForm = new Client();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}