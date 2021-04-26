using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {

        delegate bool Logic(int arg);

        delegate double Change(int arg);

       

        

        static double DegToRad(int numer)
        {
            return numer * Math.PI / 180;
        }

        static bool IsPositive(int number)
        {
            return number > 0;
        }

        static bool Is42(int number)
        {
            return number == 42;
        }

        static int CountElements(int[] arr, Func<int, bool> condition)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
                if (condition(arr[i]))
                    res++;
            return res;
        }

        static double[] Map (int[] arr, Change change)
        {
            double[] res = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                res[i] = change(arr[i]);
            return res;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Опис делегату обробника події
        public delegate void EventDelegate(string message);
        //Опис події
        public event EventDelegate MyEvent;

        //обробник сумісний з делегатом
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //підписка на подію
            MyEvent += ShowMessage;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5] { -3, 2, 0, 7, -5 };
            int ArePositive = CountElements(arr, IsPositive);
            if (ArePositive > 0)
            {
                //генеруємо настання події
                MyEvent?.Invoke($"There are {ArePositive} numbers");
                MyEvent -= ShowMessage;
            }
            int Are42 = CountElements(arr, Is42);
            MessageBox.Show(Are42.ToString());
            double[] radArr = Map(arr, DegToRad);
        }
    }
}
