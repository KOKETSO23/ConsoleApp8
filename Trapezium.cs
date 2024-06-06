using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Trapezium
    {
        double a;
        double b;
        double h;

        public Trapezium(double firstLength, double secondLength, double height)
        {
            a = firstLength;
            b = secondLength;
            h = height;
        }
        public double firstLength
        {
            get { return a; }
            set { a = value; }
        }
        public double secondLength
        {

            get { return b; }
            set { b = value; }

        }

        public double height
        {
            get { return h; }
            set { h = value; }

        }
        public double GetArea()
        {
            return 0.5 * (a + b) * h;
        }

        public void Display()
        {
            Console.WriteLine("firstLength " + firstLength);
            Console.WriteLine("secondLength" + secondLength);
            Console.WriteLine("height" +  height);
            Console.WriteLine("area" + GetArea());
        }
    }

}