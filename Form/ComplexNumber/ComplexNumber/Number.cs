using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class Number : IAbs
    {
        protected double RealValue;
        //конструктор без параметра
        public Number ()
        {
            this.RealValue = 0;
        }
        //конструктор з параметром
        public Number(double RealValue)
        {
            this.RealValue = RealValue;
        }
        //конструктор копіювання
        public Number(Number number)
        {
            this.RealValue = number.Value;
        }
        public double Value
        {
            get 
            {
                return this.RealValue;
            }
        }

        public double GetValue()
        {
            return this.RealValue;
        }
        public virtual double Abs()
        {
            return Math.Abs(this.RealValue);
        }

        public override string ToString()
        {
            return this.RealValue.ToString();
        }

    }
}
