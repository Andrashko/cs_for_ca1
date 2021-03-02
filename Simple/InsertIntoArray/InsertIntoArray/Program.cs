using System;

namespace InsertIntoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] a = new int[10] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            int newElement = -7;
            for (int i = n; i > 0; i--)
            {
                a[i] = a[i - 1];
            }
            a[0] = newElement;
            n++;
            for (int i = 0; i < n; i++)
                Console.Write("{0}  ", a[i]);
        }
    }
}
