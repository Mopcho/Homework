using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryStr = Console.ReadLine();
            double sum = 0;
            int counter = binaryStr.Length-1;
            for (int i=0;i<binaryStr.Length;i++,counter--)
            {
                if (binaryStr[i]=='1')
                {
                    sum = sum + (1 * Math.Pow(2, counter));
                }
                else if (binaryStr[i]=='0')
                {
                    sum = sum + (0 * Math.Pow(2, counter));
                }
            }
            Console.WriteLine(sum);
        }
    }
}
