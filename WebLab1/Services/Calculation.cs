using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLab1
{
    public class Calculation
    {
        Random rand = new Random();
        public double n1;
        public double n2;

        public Calculation()
        {
            n1 = rand.Next(0, 10);
            n2 = rand.Next(0, 10);
        }

        public string Plus()
        {
            return "" + n1 + " + " + n2 + " = " + (n1 + n2);
        }

        public string Minus()
        {
            return "" + n1 + " - " + n2 + " = " + (n1 - n2);
        }

        public string Multiply()
        {
            return "" + n1 + " * " + n2 + " = " + (n1 * n2);
        }

        public string Divide()
        {
            if (n2 != 0)
                return "" + n1 + " / " + n2 + " = " + Math.Floor(n1 / n2);
            else
                return "" + n1 + " / " + n2 + " = " + "Error: Division by zero";
        }
    }
}
