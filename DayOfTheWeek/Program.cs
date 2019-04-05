using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
           int day = (int)System.DateTime.Now.DayOfWeek;
            Console.WriteLine(day);
        }
    }
}
