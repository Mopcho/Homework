using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int year = int.Parse(Console.ReadLine());
            DateTime x= new DateTime(year,1,1);
           if (x.Year%4!=0)
            {
                Console.WriteLine("Common");
            }
           else if (x.Year%100!=0)
            {
                Console.WriteLine("Leap");
            }
           else if (x.Year % 400 != 0)
            {
                Console.WriteLine("Common");
            }
           else
            {
                Console.WriteLine("Leap");
            }
          

        }
    }
}
