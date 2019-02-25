using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int greaterNum;
            int smallerNum;
            int gcd=1;
            if (num1>num2)
            {
                greaterNum = num1;
                smallerNum = num2;
            }
            else
            {
                greaterNum = num1;
                smallerNum = num2;
            }
            for (int i = greaterNum; i > 0;i--)
            {
                if (num1 % i == 0 && num2%i==0)
                {
                    gcd = i;
                    break;
                }
            }
            Console.WriteLine(gcd);
        }
    }
}
