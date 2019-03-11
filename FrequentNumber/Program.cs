using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
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
            int biggest = 0;
            int counter = 0;
            int biggestCounter = 0;
            for (int i=0;i<n;i++)
            {
                for (int a=0;a<n;a++)
                {
                    if (i==a)
                    {

                    }
                    else if (Arr[i]==Arr[a])
                    {
                        counter++;
                    }

                }
                if (biggest<counter)
                {
                    biggest = i;
                }
                if (biggestCounter<counter)
                {
                    biggestCounter = counter;
                }
                counter = 0;
            }
            Console.WriteLine("{0} ({1})",Arr[biggest],biggestCounter+1);
        }
    }
}
