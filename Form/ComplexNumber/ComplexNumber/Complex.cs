using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class Complex : Number
    {
        private double ImValue;
        public Complex():base()
        {
            this.ImValue = 0;
        }

        public Complex(double re, double im): base(re)
        {
            this.ImValue = im;
        }

        public Complex(Complex number)
        {
            this.RealValue = number.Re;
            this.ImValue = number.Im;
        }

        public double Re
        {
            get
            {
                return this.RealValue;
            }
        }


        public double Im
        {
            get
            {
                return this.ImValue;
            }
        }

        public override double Abs()
        {
            return Math.Sqrt(Math.Pow(this.RealValue, 2) + Math.Pow(this.ImValue, 2));
        }

        public override string ToString()
        {
            string str = "";
            if (this.RealValue == 0 && this.ImValue == 0)
                return "0";
            if (this.RealValue != 0)
                str += this.RealValue.ToString();
            if (this.ImValue > 0)
                str += $"+{this.ImValue.ToString()}i";
            if (this.ImValue < 0)
                str += $"{this.ImValue.ToString()}i";
            return str;
        }

        public static Complex operator + (Complex number1, Complex number2)
        {
            return new Complex(
                number1.Re + number2.Re,
                number1.Im + number2.Im
                );
        }

        public static Complex operator * (double number1, Complex number2)
        {
            return new Complex(
                number1 * number2.RealValue,
                number1 * number2.ImValue
                );
        }

        public static Complex operator * (Complex number1, Complex number2)
        {
            return new Complex(
                number1.Re * number2.Re - number1.Im * number2.Im,
                number1.Re * number2.Im + number1.Im * number2.Re
                );
        }

        public static bool operator == (Complex number1, Complex number2)
        {
            return number1.Re == number2.Re && number1.Im == number2.Im;
        }

        public static bool operator != (Complex number1, Complex number2)
        {
            return !(number1.Re == number2.Re && number1.Im == number2.Im);
        }
    }
}
