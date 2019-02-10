using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double point =Math.Sqrt(Math.Pow((x - 0),2)+Math.Pow((y-0),2));
        if (point>2)
            {
                Console.WriteLine("no {0:f2}",point);
            }
        else 
            {
                Console.WriteLine("yes {0:f2}",point);


            }
            Console.ReadLine();
        }
    }
}
