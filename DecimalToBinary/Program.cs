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
            string holder = "";

            for (int i=0;fakeDec>=1;i++,counter++)
            {
                int num = fakeDec % 2;

                fakeDec = fakeDec / 2;

            }


            string[] charArr = new string[counter];
           

            for (int a = 0; dec>=1; a++)
            {
                int num2 = dec % 2;
                charArr[a] =num2.ToString();
                dec = dec / 2;
            }


            string[] charArr2 = new string[counter];
            int e = 0;



             for (int d=counter-1;e<counter;d--,e++)
            {
                
                charArr2[d] = charArr[e];
            }



            for (int c=0;c<counter;c++)
            {
                Console.Write("{0} ", charArr2[c]);
            }
           
            
        }
    }
}
