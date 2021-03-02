using System;

namespace Lab_4_2
{
    class Program
    {
        //n!
        static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return Factorial(n - 1) * n;
        }
        //1**2+2**2+...+n**2
        static long SumOfSquares(int n)
        {
            long s = 0;
            for (int i = 1; i <= n; i++)
                s += i * i;
            return s;
        }

        //Побудувати квадратну матрицю А, елементи якої задаються формулою:
        static double[][] GenerateMatrixByFormula(int RowAndColCount)
        {
            //[[1,2],[3,4]]
            double[][] result = new double[RowAndColCount][]; // result = [[],[]]
            for(int i = 0; i < RowAndColCount; i++)
            {
                result[i] = new double[RowAndColCount]; //result=[[0,0],[]]
                for(int j = 0; j < RowAndColCount; j++)
                {
                    if ((i+j) % 2 == 0)
                        //парне
                        result[i][j] = Factorial(i);
                    else
                        //непарне
                        result[i][j] = SumOfSquares(j);
                }
            }

            return result;
        }

        static void PrintMatrix(double[][] matrix,  int rowCount, int colCount)
        {
            for(int i=0;i<rowCount;i++)
            {
                for (int j = 0; j < colCount; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            PrintMatrix(GenerateMatrixByFormula(n),n,n);

        }
    }
}
