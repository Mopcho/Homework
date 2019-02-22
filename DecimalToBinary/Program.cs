using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            int fakeDec = dec;
            int counter = 0;
            for (int i=0;fakeDec>=1;i++,counter++)
            {
                int num = fakeDec % 2;
                Console.Write("{0} ", num);
                fakeDec = fakeDec / 2;

            }
            int secDec = dec;
            for (int c = 0; c < counter-1; c++) {
                dec = dec / 2;
                Console.WriteLine(dec);
                    }
            for (int a=0;dec<secDec;a++)
            {
                int sum1 = dec % 2;
                Console.Write(sum1);
                dec = dec * 2;
            }
        }
    }
}
