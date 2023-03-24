using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
        }

        private void Exchange_Click(object sender, EventArgs e)
        {
            long money;
            money = long.Parse(MoneyNeedsToChange.Text);
            if (Currency.Text == "USD")
            {
                MoneyIsChanged.Text = (money * 22772).ToString("N", new CultureInfo("en-US"));
            }
            else if (Currency.Text == "EUR")
            {
                MoneyIsChanged.Text = (money * 28132).ToString("N", new CultureInfo("en-US"));
            }
            else if (Currency.Text == "GBP")
            {
                MoneyIsChanged.Text = (money * 31538).ToString("N", new CultureInfo("en-US"));
            }
            else if (Currency.Text == "SGD")
            {
                MoneyIsChanged.Text = (money * 17286).ToString("N", new CultureInfo("en-US"));
            }
            else if (Currency.Text == "JPY")
            {
                MoneyIsChanged.Text = (money * 214).ToString("N", new CultureInfo("en-US"));
            }
        }
    }
}
