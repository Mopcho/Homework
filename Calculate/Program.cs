using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double facI = 1;
            double sum = 1+1/x;
              for (int i=2;i<=n;i++)
            {
              
                    facI = facI * i;
               
                sum = sum + (facI / (Math.Pow(x, i)));
             
            }
            Console.WriteLine(sum);
        }
    }
}
