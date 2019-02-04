using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            
            string numbStr = numb.ToString();
            
            int strLeng = numbStr.Length;
            int thirdDigit = strLeng - 3;
            char thirdDigitString = numbStr[thirdDigit];
            if (thirdDigitString == '7')
            {
                Console.WriteLine("true {0}", numbStr[thirdDigit]);


            }
            else
            {
                Console.WriteLine("false {0}", numbStr[thirdDigit]);
            }
            Console.ReadLine();
        }
    }
}
