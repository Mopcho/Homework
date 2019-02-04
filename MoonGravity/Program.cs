using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class Program
    {
        static void Main(string[] args)
        {
            int weightOnEarth =int.Parse(Console.ReadLine());
           
            double weightOnMoon = 0.17*weightOnEarth;
            Console.WriteLine("{0:f3}",weightOnMoon);
            Console.ReadLine();
        }
    }
}
