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
    public partial class Bai_5 : Form
    {
        public Bai_5()
        {
            InitializeComponent();
        }


        private void Calculate_Click_1(object sender, EventArgs e)
        {
            int num1, num2, sumA, sumB, factorialA, factorialB, exponent;
            num1 = int.Parse(ValueA.Text);
            num2 = int.Parse(ValueB.Text);
            sumA = 0;
            sumB = 0;
            factorialA = 1;
            factorialB = 1;
            exponent = 0;
            for (int i = 1; i <= num1; i++)
            {
                sumA += i;

            }
            SumS1.Text = "1 + 2 + 3 + 4 + 5 +... + A = " + sumA.ToString("N0");
            for (int j = 1; j <= num2; j++)
            {
                sumB += j;
            }
            SumS2.Text = "1 + 2 + 3 + 4 + 5 +... + B = " + sumB.ToString("N0");
            for (int x = 1; x <= num1; x++)
            {
                factorialA *= x;
            }
            FactorialA.Text = "A! = " + factorialA.ToString("N0");
            for (int y = 1; y <= num2; y++)
            {
                factorialB *= y;
            }
            FactorialB.Text = "B! = " + factorialB.ToString("N0");
            for (int z = 1; z <= num2; z++)
            {
                exponent += (int)Math.Pow(num1, z);
            }
            SumS3.Text = "A^1 + A^2 + A^3 + ... + A^B = " + exponent.ToString("N0");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ValueB.Text = string.Empty;
            ValueA.Text = string.Empty;
            SumS3.Text = string.Empty;
            SumS1.Text = string.Empty;
            SumS2.Text = string.Empty;
            FactorialA.Text = string.Empty;
            FactorialB.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
