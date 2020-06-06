using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception ex = new InvalidRangeException<int>(10,20);
            Console.WriteLine(ex.Message); 
           try
            {
                int begin = 1;
                int end = 100;
                int number = 150;

                if (begin<number && end < number)
                {
                    throw new InvalidRangeException<int>(begin,end);
                }
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.WriteLine(ire.Message);
                Console.WriteLine($"Begin : {ire.Begin} End : {ire.Last} ");
            }
            try
            {
                DateTime begin = new DateTime(1980, 1, 1);
                DateTime last = new DateTime(2013, 12, 31);
                DateTime date = new DateTime(2014, 2, 1);

                if (begin < date && date > last)
                    throw new InvalidRangeException<DateTime>(begin, last);
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine(ire.Message);
                Console.WriteLine("Begin: {0}, Last: {1}", ire.Begin, ire.Last);
            }
        }
    }
}
