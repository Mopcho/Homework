using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int scale = 0;
            int previousScale = 1;
            int secPreviousScale = 0;
            if (n < 2)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("0");
                        break;
                    case 2:
                        Console.WriteLine("1");
                        break;

                }
            }
            else
            {
                Console.Write("0 1 ");

                for (int i = 0; i < n - 2; i++)
                {

                    for (int a = 0; a < 1; a++)
                    {
                        scale = previousScale + secPreviousScale;
                        Console.Write("{0} ", scale);
                    }
                    secPreviousScale = previousScale;
                    previousScale = scale;

                }
            }
        }
    }
}
