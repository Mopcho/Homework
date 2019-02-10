using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = 2 * width + 2 * height;
            Console.WriteLine("{0:f2} {1:f2}", area, perimeter);
            Console.ReadLine();

        }
    }
}
