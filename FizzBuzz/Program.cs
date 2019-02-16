using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string fizz = "Fizz ";
            string buzz = "Buzz";
            for (int i=1;i<100;i++)
            {
                if (i%3==0 && i%5==0)
                {
                    Console.WriteLine(fizz+buzz);
                }
                  else if (i%3==0 && i%5!=0)
                {
                    Console.WriteLine(fizz);
                }
                else if (i%5==0 && i%3!=0)
                {
                    Console.WriteLine(buzz);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
