using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIsBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            for (int i=0;i<n;i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            int oddSum = 0;
            int evenSum = 0;
            for (int i=0;i<n;i++)
            {
                if (Arr[i]%2==0)
                {
                    evenSum = evenSum + Arr[i];
                }
                else
                {
                    oddSum = oddSum + Arr[i];
                }
            }
            if (evenSum>oddSum)
            {
                Console.WriteLine("{0} EVEN", evenSum);
            }
            else if (evenSum<oddSum)
            {
                Console.WriteLine("{0} ODD", oddSum);
            }
            else
            {
                Console.WriteLine("{0} Equal", evenSum);
            }
        }
    }
}
