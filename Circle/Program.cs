using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
           const double pi  = 3.14;
            double area = pi * Math.Pow(r, 2);
            double perimeter = (2 * r) * pi;
            Console.Write("{0:f2} ",perimeter);
            Console.WriteLine("{0:f2} ",area);
            Console.ReadLine();
        }
    }
}
