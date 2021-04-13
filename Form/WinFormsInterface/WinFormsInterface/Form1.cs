using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IProgression progression;
        private void button1_Click(object sender, EventArgs e)
        {
            double a0 = double.Parse(textBoxA0.Text);
            double d = double.Parse(textBoxD.Text);
            if (comboBox1.Text == "Арифметична")
                progression = new ArithmeticProgression(a0, d);
            if (comboBox1.Text == "Геометрична")
                progression = new GeometricProgression(a0, d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDownN.Value);
            textBoxS.Text = progression.SumOfFirstNthElements(n).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDownN.Value);
            textBoxAn.Text = progression.NthElement(n).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDownN.Value);
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = 1;
            dataGridView1.Rows[0].Cells[0].Value = (progression as ISequence).First();
            for (int i = 1; i < n; i++)
                dataGridView1.Rows[0].Cells[i].Value = (progression as ISequence).Next();
        }
    }
}
