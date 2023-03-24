using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }

        private void SoThuNhat_Click(object sender, EventArgs e)
        {

        }

        private void SoThuHai_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            if (int.TryParse(textBox1.Text.Trim(), out num1) == false || int.TryParse(textBox2.Text.Trim(), out num2) == false)
            {
                MessageBox.Show("Vui lòng nhập lại số nguyên");
                return;
            }
            num1 = Int32.Parse(textBox1.Text.Trim());
            num2 = Int32.Parse(textBox2.Text.Trim());
            int sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

    }
}
