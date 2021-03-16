using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PointToStr_Click(object sender, EventArgs e)
        {
            Dot dot1 = new Dot(Convert.ToInt32(tbX.Text), Convert.ToInt32(tbY.Text));
            tbStr.Text = dot1.str();
        }

        private void FindDistance_Click(object sender, EventArgs e)
        {
            Dot dot1 = new Dot(Convert.ToInt32(tbX.Text), Convert.ToInt32(tbY.Text));
            Dot dot2 = new Dot(Convert.ToInt32(tbX2.Text), Convert.ToInt32(tbY2.Text));
            tbStr.Text = dot1.Distance(dot2).ToString();
            tbStr.Text = Dot.Distance(dot1, dot2).ToString();

        }

        private Dot dotToMove = null;
        private void Move_Click(object sender, EventArgs e)
        {
            if (dotToMove == null)
            {
                dotToMove = new Dot(Convert.ToInt32(tbX.Text), Convert.ToInt32(tbY.Text));
            }
            dotToMove.Move(1, 1);
            tbStr.Text = dotToMove.str();
        }


        private Plant plant = new Plant();
        private void button1_Click(object sender, EventArgs e)
        {
            plant.GenerateRandomData(5);
        }

        private void ShowEmploeerList (List<Emploeer> list)
        {
            dataGridView1.RowCount = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value = list[i].FullName;
                dataGridView1.Rows[i].Cells[2].Value = list[i].StartWork;
                dataGridView1.Rows[i].Cells[3].Value = list[i].StartPost;
                dataGridView1.Rows[i].Cells[4].Value = list[i].Prepayment;
                dataGridView1.Rows[i].Cells[5].Value = list[i].Remuneration;
                dataGridView1.Rows[i].Cells[6].Value = list[i].Post;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            ShowEmploeerList(plant.emploeers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowEmploeerList(plant.getMoreThenAvarageSeleryList());
        }
    }
}
