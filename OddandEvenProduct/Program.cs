using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddandEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 1;
            int oddSum = 1;
            
            for (int i=1;i<=n;i++)
            {
                if (i%2==0)
                {
                    int Num = int.Parse(Console.ReadLine());
                    evenSum = evenSum * Num;
                }
                else
                {
                    int Num = int.Parse(Console.ReadLine());
                    oddSum = oddSum * Num;
                }
            }
            if (evenSum!=oddSum)
            {
                Console.WriteLine("No {0} {1}", oddSum, evenSum);
            }
            
            else if (evenSum==oddSum)
            {
                Console.WriteLine("Yes {0}",evenSum);
            }
        }
    }
}
