using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class Program
    {
        public static void Factorial(int n)
        {
            int sum = n;
            for (int i =n-1; i >= 1; i--)
            {
                sum =sum*i;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Factorial(n);
        }
    }
}
