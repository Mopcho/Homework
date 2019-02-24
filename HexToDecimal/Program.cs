using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            string dec = "";
            double num;
            double sum = 0;
            int pow = hex.Length-1;
            for (int i=0;i<hex.Length;i++,pow--)
            {
                switch (hex[i])
                {
                    case 'A':
                        num = 10;
                        break;
                    case 'B':
                        num = 11;
                        break;
                    case 'C':
                        num = 12;
                        break;
                    case 'D':
                        num = 13;
                        break;
                    case 'E':
                        num = 14;
                        break;
                    case 'F':
                        num = 15;
                        break;
                    default:
                        num = double.Parse(hex[i].ToString());
                        break;

                }
                sum = sum + (num * Math.Pow(16, pow));
            }
            Console.WriteLine(sum);
        }
    }
}
