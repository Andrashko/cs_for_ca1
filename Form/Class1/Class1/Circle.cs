using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Circle: Figure
    {
        private double _Radius;
        public double Radius { get
            {
                return this._Radius;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Negative Radius");
                else
                    this._Radius = value;
            }
        }

        public Circle(int x, int y, double Radius): base(x,y)
        {
            this.Radius = Radius;
        }

        public Circle(Circle circle): base(circle.x, circle.y)
        {
            this.Radius = circle.Radius;
        }
    }
}
