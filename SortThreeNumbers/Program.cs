using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            int Num3 = int.Parse(Console.ReadLine());
            if (Num1>Num2 && Num1>Num3)
            {
                if (Num2>Num3)
                {
                    Console.WriteLine("{0} {1} {2}", Num1, Num2, Num3);
                }
                else if (Num3>Num2)
                {
                    Console.WriteLine("{0} {1} {2}", Num1, Num3, Num2);
                }
            }
            else if (Num2>Num1 && Num2>Num3)
            {
                if (Num1 > Num3)
                {
                    Console.WriteLine("{0} {1} {2}", Num2, Num1, Num3);
                }
                else if (Num1 < Num3)
                {
                    Console.WriteLine("{0} {1} {2}", Num2, Num3, Num1);
                }

            }
            else if (Num3>Num2 && Num3>Num1)
            {
                if (Num2   > Num1)
                {
                    Console.WriteLine("{0} {1} {2}", Num3, Num2, Num1);
                }
                else if (Num1 > Num2)
                {
                    Console.WriteLine("{0} {1} {2}", Num3, Num1, Num2);
                }
            }
        }
    }
}
