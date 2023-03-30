namespace Week3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            Server myForm = new Server();            
            myForm.ShowDialog();      
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client myForm = new Client();
            myForm.ShowDialog();           
        }
    }
}