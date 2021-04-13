using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInterface
{
    class GeometricProgression: IProgression, ISequence
    {
        //2 4 6 8
        private double b0;
        private double q;
        public GeometricProgression(double StartElement, double Ratio)
        {
            this.b0 = StartElement;
            this.q = Ratio;
        }
        public double NthElement(int n)
        {
            return b0 * Math.Pow(q, n);
        }
        public double SumOfFirstNthElements(int n)
        {
            return b0*(Math.Pow(q, n)-1)/(q-1);
        }

        private int Current = 0;
        public double First()
        {
            Current = 0;
            return this.b0;
        }

        public double Next()
        {
            return NthElement(++Current);
        }
    }
}
