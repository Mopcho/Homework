using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i=1;i<=n;i++) 
            {
                counter = i;
                for (int a=1;a<=n;a++,counter++)
                {
                    Console.Write(counter);
                }
                
                Console.WriteLine();
            }
        }
    }
}
