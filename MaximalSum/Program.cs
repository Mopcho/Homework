using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
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
            int holderN = n;
            int counter = 0;
            int sum = 0;
            int indexCounter = 0;
            int[] sumArr = new int[n];
            for (int i=0;i<n;i++)
            {
                for (int a=counter;a<n;a++,indexCounter++)
                {
                    sum = sum + Arr[indexCounter];
                }
                sumArr[i] = sum;
                counter++;
                indexCounter = counter;
                sum = 0;
            }
            int biggest = -1000;
            for (int i=0;i<n;i++)
            {
                if (sumArr[i]>biggest)
                {
                    biggest = sumArr[i];
                }
            }
            Console.WriteLine(biggest);

        }
    }
}
