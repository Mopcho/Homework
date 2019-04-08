using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByThreeSides
{
    class Triangle
    {
        private double p;
        public double surface(double a,double b,double c)
        {
            double S;
            double p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(tr.surface(a, b, c));

        }
    }
}
