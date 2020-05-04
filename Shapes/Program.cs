using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape
    {
        protected Location c;

        public string ToString()
        {
            return "";
        }

        public double Area()
        {
            return 0.000;
        }

        public double Perimeter()
        {
            return 0.000;
        }
    }

    class Rectangle : Shape
    {
        protected double side1, side2;
    }

    class Circle : Shape
    {
        protected double radius;
    }

    class Location
    {
        private double x, y;
    }

    class TestShape
    {
        static void Main()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
