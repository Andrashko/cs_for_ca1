using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInterface
{
    class ArithmeticProgression : IProgression, ISequence
    {
        //1 3 5 7 
        private double a0;
        private double d;
        public ArithmeticProgression(double StartElement, double Difference)
        {
            this.a0 = StartElement;
            this.d = Difference;
        }
        public double NthElement(int n)
        {
            //if (n == 0)
            //    return this.a0;
            //return this.NthElement(n - 1) + this.d;
            return a0 + n * d;
        }
        public double SumOfFirstNthElements(int n)
        {
            return (2*a0+(n-1)*d)/2*n;
        }

        private int Current = 0;
        public double First()
        {
            Current = 0;
            return this.a0;
        }

        public double Next()
        {
            return NthElement(++Current);
        }
    }
}
