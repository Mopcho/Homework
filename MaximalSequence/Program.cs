using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            int c = 0;
            int[] Arr1 = new int[n];
            int counter = 0;
            for (int i=0;i<n;i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i=1;i<n;i++,counter++)
            {
              
                if (Arr[i]==Arr[i-1])
                {
                    c++;
                }
                else
                {
                    c = 0;
                }
                Arr1[counter] = c;
            }
            int biggest = 0;
            for (int a=0;a<n;a++)
            {
                if (Arr1[a]>biggest)
                {
                    biggest = Arr1[a];
                }
            }
            Console.WriteLine(biggest+1);
        }
    }
}
