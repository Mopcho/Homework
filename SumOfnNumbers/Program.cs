using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfnNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum=0;

            for (int i=0;i<n;i++)
            {
                double a = double.Parse(Console.ReadLine());
                sum =sum+ a;

            }
            Console.WriteLine(sum);
        }
    }
}
