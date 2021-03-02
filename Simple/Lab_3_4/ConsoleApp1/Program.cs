using System;

namespace Lab_3_4
{
    class Program
    {
        static double[] InputArray(int len)
        {
            double[] result = new double[len];
            for (int i = 0; i < len; i++)
                result[i] = double.Parse(Console.ReadLine());
            return result;
        }

        static void PrintArray(double[] arr, int len)
        {
            for (int i = 0; i < len; i++)
                Console.Write("{0}, ",arr[i]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            /*
             Перетворити масив таким чином, щоб спочатку розміщувались всі елементи, ціла
                частина яких лежить в інтервалі [a,b] , а потім всі інші.
             */
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[] arr = InputArray(n);
            int FirstOutOfInterval = 0;
            int FirstInInterval = 0;
            while (FirstInInterval<n && FirstOutOfInterval < n)
            {
                while(FirstOutOfInterval<n && !(Math.Floor(arr[FirstOutOfInterval])> b || Math.Floor(arr[FirstOutOfInterval]) < a))
                {
                    FirstOutOfInterval++;
                }
                while (FirstInInterval<n && ! (a <= Math.Floor(arr[FirstInInterval]) && Math.Floor(arr[FirstInInterval]) <= b))
                {
                    FirstInInterval++;
                }
                if (FirstInInterval == n || FirstOutOfInterval == n)
                    break;
                double temp = arr[FirstInInterval];
                arr[FirstInInterval] = arr[FirstOutOfInterval];
                arr[FirstOutOfInterval] = temp;
            }
            PrintArray(arr, n);
            /*
             1,2,3,4,5,6,7
            [3;5]
            3,4,5,1,2,6,7
            3,4,5,2,1,6,7
             */
        }
    }
}
