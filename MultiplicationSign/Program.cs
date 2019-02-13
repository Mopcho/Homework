using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1>0 && num2>0 && num3>0)
            {
                Console.WriteLine("+");
            }
            else if (num1==0 || num2==0 || num3==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-");
            }






            Console.ReadLine();



        }
    }
}
