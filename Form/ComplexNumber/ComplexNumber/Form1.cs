using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Complex GetNumber()
        {
            return new Complex(
                double.Parse(textBoxRe.Text),
                double.Parse(textBoxIm.Text)
                );
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Complex number = GetNumber();
            textBoxStr.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Complex number = GetNumber();
            textBoxStr.Text = number.Abs().ToString();
            label3.Text = "Abs";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Complex number1 = GetNumber();
            Complex number2 = new Complex(1, 2);
            Complex sum = number1 + number2;
            textBoxStr.Text = $"{number1.ToString()} + {number2.ToString()} = {sum.ToString()}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double k = 3;
            Complex number2 = GetNumber();
            Complex prod = k*number2;
            textBoxStr.Text = $"{k.ToString()} * {number2.ToString()} = {prod.ToString()}";
        }
    }
}
