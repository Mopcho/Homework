using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            string numbStr = numb.ToString();
            int sum = 0;
            
            while (numb != 0)
            {
                sum += numb % 10;
                numb /= 10;
            }
            Console.WriteLine(sum);
            int strLeng = numbStr.Length;


          
            char[] charArr = numbStr.ToCharArray();

            char[] charArr1 = numbStr.ToCharArray();
            charArr1[1] = charArr[2];
            charArr1[2] = charArr[1];
            Array.Reverse(charArr);
           for (int i=0;i<strLeng;i++)
            {
                Console.Write(charArr[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < strLeng; i++)
            {
                Console.Write(charArr1[i]);
            }

            Console.ReadLine();
        }
    }
}
