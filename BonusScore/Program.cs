using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int n = int.Parse(Console.ReadLine());
                if (n <= 3 && n > 0)
                {
                    n = n * 10;
                    Console.WriteLine(n);
                }
                else if (n >= 4 && n <= 6)
                {

                    n = n * 100;
                    Console.WriteLine(n);
                }
                else if (n >= 7 && n <= 9)
                {
                    n = n * 1000;
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("invalid score");
                }
               


            

            Console.ReadLine();
        }
    }
}
