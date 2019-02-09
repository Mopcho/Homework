using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloatingPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double con = 0.000001;
            double difference;
            if (num1 > num2)
            {
                 difference = num1 - num2;
            }
            else
            {
                difference = num2 - num1;
            }

            if (difference<con)
            {
                Console.WriteLine("The same");

            }
            else
            {
                Console.WriteLine("Different");
            }
        }
    }
}
