using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int c = 0;
            if (inputNum < 0 || inputNum == 0)
            {
                Console.WriteLine("False");
                inputNum = 1000;
            }
            else
            {
                for (int i = 1; i < inputNum; i++)
                {
                    if (i == inputNum || i == 1)
                    {

                    }
                    else if (inputNum % i == 0)
                    {
                        Console.WriteLine("Not Prime");
                        c++;
                        break;

                    }
                }
            }
            if (c<=0)
            {
                Console.WriteLine("Prime");
            }
            Console.ReadLine();

        }
    }
}
