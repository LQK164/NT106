using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB01
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void Checking_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, max, min;
            num1 = double.Parse(NhapNo1.Text);
            num2 = double.Parse(NhapNo2.Text);
            num3 = double.Parse(NhapNo3.Text);
            max = num1;
            min = num1;
            if (num1 >= num2 && num1 >= num3)
            {
                max = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                max = num2;
            }
            else if (num3 >= num2 && num3 >= num2)
            {
                max = num3;
            }
            SoLonNhat.Text = max.ToString();
            if (num1 <= num2 && num1 <= num3)
            {
                min = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                min = num2;
            }
            else if (num3 <= num2 && num3 <= num2)
            {
                min = num3;
            }
            SoNhoNhat.Text = min.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            {
                NhapNo1.Text = null;
                NhapNo2.Text = null;
                NhapNo3.Text = null;
                SoLonNhat.Text = null;
                SoNhoNhat.Text = null;
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
