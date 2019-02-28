using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
           
         
            int sumA=0;
            int sumB=0;
            for (int i = 0; i < a.Length; i++)
            {
                sumA = sumA + a[i];
            }
            for (int c = 0; c < b.Length; c++)
            {
                sumB = sumB + b[c];
            }
            Console.WriteLine(sumA);
            Console.WriteLine(sumB);
            if (sumA < sumB)
            {
                Console.WriteLine("<");
            }
            else if (sumA>sumB)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
