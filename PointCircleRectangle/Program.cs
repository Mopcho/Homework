using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double pointCircle = Math.Sqrt(Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2));
            bool checkRectangle = ((x >= -1 && x <= 5) && (y <= 1 && y >= -1));
            if (pointCircle<=1.5)
            {
                Console.WriteLine("Inside Circle ");
            }
            else
            {
                Console.WriteLine("Outside Circle");
            }
            
            if (checkRectangle)
            {
                Console.WriteLine("Inside Rectangle");


            }
            else
            {
                Console.WriteLine("Outside Rectangle");

            }
        }
    }
}
