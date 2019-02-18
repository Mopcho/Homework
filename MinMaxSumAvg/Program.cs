using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double min = 1000000;
            double max = -100000;
            double sum = 0;
            double avr = 0;
            for (int i=0;i<n;i++)
            {
                double Num = double.Parse(Console.ReadLine());
                if (Num<min)
                {
                    min = Num;
                }
                if (Num>max)
                {
                    max = Num;
                }
                sum = Num + sum;
                
            }
            avr = sum / n;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
            Console.WriteLine(avr);
        }
    }
}
