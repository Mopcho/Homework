using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class Triangle
    {
        private double p;
        public double surface(double a, double b, double h)
        {
            double S;
            S = (a * b * Math.Sin(toRadians(h))) / 2;
            return S;
        }
        public double toRadians(double h)
        {
            return Math.PI * h / 180;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(tr.surface(a, b, h));
            
        }
    }
}
