namespace LAB01
{
    public partial class Overall : Form
    {
        public Overall()
        {
            InitializeComponent();
        }

        private void bai01_Click(object sender, EventArgs e)
        {
            Bai_1 myForm = new Bai_1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void bai02_Click(object sender, EventArgs e)
        {
            Bai_2 myForm = new Bai_2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void bai03_Click(object sender, EventArgs e)
        {
           Bai_3 myForm = new Bai_3();      
           this.Hide();
           myForm.ShowDialog();
           this.Close();
        }

        private void bai04_Click(object sender, EventArgs e)
        {
            Bai_4 myForm = new Bai_4();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void bai05_Click(object sender, EventArgs e)
        {
            Bai_5 myForm = new Bai_5();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}