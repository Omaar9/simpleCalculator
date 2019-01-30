using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    public class Calculator
    {
        //Addition:
        public double Add(double a, double b)
        {
            return a + b;
        }

        //Subtract:

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        //Multiply
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        //Power
        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

    }
}
