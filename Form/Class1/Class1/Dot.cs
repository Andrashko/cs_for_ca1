using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Dot: Figure
    {
        public Dot() : base(0, 0)
        {

        }
        public Dot(int x, int y) : base(x, y)
        {

        }


        public string str()
        {
            return $"dot ({this.x};{this.y})";
        }

        //відстань до іншої точки
        public double Distance(Dot otherDot)
        {
            return Math.Sqrt(Math.Pow(otherDot.x - this.x, 2) + Math.Pow(otherDot.y - this.y, 2));
        }

        //відстант між 2 точками
        public static double Distance(Dot dot1, Dot dot2)
        {
            return dot1.Distance(dot2);
        }

        
        
    }
}
