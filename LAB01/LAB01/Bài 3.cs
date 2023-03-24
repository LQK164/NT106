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
    public partial class Bai_3 : Form
    {
        public Bai_3()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            int number;
            number = int.Parse(Nhap_Tu_0_Den_9.Text);
            switch (number)
            {
                case 0:
                    Ket_Qua.Text = Convert.ToString("Không");
                    break;
                case 1:
                    Ket_Qua.Text = Convert.ToString("Một");
                    break;
                case 2:
                    Ket_Qua.Text = Convert.ToString("Hai");
                    break;
                case 3:
                    Ket_Qua.Text = Convert.ToString("Ba");
                    break;
                case 4:
                    Ket_Qua.Text = Convert.ToString("Bốn");
                    break;
                case 5:
                    Ket_Qua.Text = Convert.ToString("Năm");
                    break;
                case 6:
                    Ket_Qua.Text = Convert.ToString("Sáu");
                    break;
                case 7:
                    Ket_Qua.Text = Convert.ToString("Bảy");
                    break;
                case 8:
                    Ket_Qua.Text = Convert.ToString("Tám");
                    break;
                case 9:
                    Ket_Qua.Text = Convert.ToString("Chín");
                    break;
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            Nhap_Tu_0_Den_9.Text = string.Empty;
            Ket_Qua.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
