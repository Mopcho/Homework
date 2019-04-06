using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceBySideAndAltitude
{
    class Program
    {
        class Triangle
        {
            public double surface(double side,double altitude ) {
                double surface = (side * altitude)/2;
                return surface;
            }
        }
        static void Main(string[] args)
        {
            Triangle tr = new Triangle();
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine(tr.surface(side,altitude));
        }
    }
}
