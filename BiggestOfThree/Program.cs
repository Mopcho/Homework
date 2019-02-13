using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            if (num1>num2 && num1>3)
            {
                Console.WriteLine(num1);
            }
            else if  (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 > num2 && num3 > num2)
            {
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine(num1);
            }
        }
    }
}
