﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DBSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //FillTestData();
            //Show(_db.GetAll());
        }

        private PcDatabase _db = new PcDatabase();
        private void FillTestData()
        {
            _db.Add(new PC(
                "Intel i7",
                3.5,
                16,
                1000,
                "GTX1050",
                950
                ));
            _db.Add(new PC(
               "Intel i5",
               3.2,
               8,
               500,
               "Radeon 460",
               750
               ));
            _db.Add(new PC(
             "AMD Ryzen R9",
             4.9,
             32,
             4000,
             "RTX3080",
             2000
             ));
        }

        private void Show(List<PC> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Нема що виводити");
                return;
            }
            dataGridView1.RowCount = list.Count;
            for (int i=0;i<list.Count;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = list[i].Processor;
                dataGridView1.Rows[i].Cells[1].Value = list[i].Frequency;
                dataGridView1.Rows[i].Cells[2].Value = list[i].RamVolume;
                dataGridView1.Rows[i].Cells[3].Value = list[i].HddVolume;
                dataGridView1.Rows[i].Cells[4].Value = list[i].Videocard;
                dataGridView1.Rows[i].Cells[5].Value = list[i].Price;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Show(_db.GetAll());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PC newPc = new PC(
                textBoxProcessor.Text,
                double.Parse(textBoxFraquency.Text),
                0,
                0,
                "",
                0
                );
            _db.Add(newPc);
            Show(_db.GetAll());
            tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            PC PcToDelete = _db.GetByIndex(i);
            _db.Remove(PcToDelete);
            Show(_db.GetAll());
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
           double MaxPrice = double.Parse(textBoxMaxPrice.Text);
           
           Show(_db.Query(pc => pc.Price<=MaxPrice));
            tabControl1.SelectedIndex = 0; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string processor = textBoxProc.Text;
            Show(_db.Query(pc => pc.Processor.ToUpper().Contains(processor.ToUpper())));
            tabControl1.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader file = new StreamReader("data.txt");
                int number = Convert.ToInt32(file.ReadLine());
                MessageBox.Show(number.ToString());
                string text = file.ReadLine();
                MessageBox.Show(text);
                string strArr = file.ReadLine();
                file.Close();
                string[] splited = strArr.Split();
                int[] numbers = new int[splited.Length];
                int sum = 0;
                for (int i = 0; i < splited.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(splited[i]);
                    sum += numbers[i];
                }
                MessageBox.Show(sum.ToString());
            } 
            catch  (FileNotFoundException err)
            {
                MessageBox.Show("Файл не знайдено");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Інша помилка {err.Message}") ;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter file = new StreamWriter("out.txt", true);
                Random rnd = new Random();
                double num = rnd.NextDouble();
                file.WriteLine(num.ToString());
                file.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this._db.SaveToFile(saveFileDialog1.FileName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this._db.ReadFromFile(openFileDialog1.FileName);
                this.Show(this._db.GetAll());
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
