using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class Program
    {
        public static void Minimum(int[] Arr)
        {
            int minimum = 1000;
            for (int i = 0; i < 5; i++)
            {
                if (minimum>Arr[i])
                {
                    minimum = Arr[i];
                }
            }
            Console.WriteLine(minimum);
        }
        public static void Maximum(int[] Arr)
        {
            int maximum = -1000;
            for (int i = 0; i < 5; i++)
            {
                if (maximum < Arr[i])
                {
                    maximum = Arr[i];
                }
            }
            Console.WriteLine(maximum);
        }
        public static void Average(int[] Arr)
        {
            double average = 0;
            for (int i = 0; i < 5; i++)
            {
                average = average + Arr[i];
            }
            average = average / 5;
            Console.WriteLine("{0:f2}",average);
        }
        public static void Sum(int[] Arr)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += Arr[i];
            }
            Console.WriteLine(sum);
        }
        public static void Product(int[] Arr)
        {
            int product = 1;
            for (int i = 0; i < 5; i++)
            {
               
                product *= Arr[i];
            }
            Console.WriteLine(product);
        }
        static void Main(string[] args)
        {
            int[] Arr = new int[5];
            for (int i=0;i<5;i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Minimum(Arr);
            Maximum(Arr);
            Average(Arr);
            Sum(Arr);
            Product(Arr);

       
        }
    }
}
