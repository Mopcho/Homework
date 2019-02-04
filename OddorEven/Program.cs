using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine("Even {0}", number);
            }
            else
            {
                Console.WriteLine("Odd {0}",number);


            }
            Console.ReadLine();
        }
    }
}
