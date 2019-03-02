using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] Arr = new int[n];
            int[] Arr1 = new int[n];
            int holderA = 0;
            
            for (int i = 0; i < n; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            int small = Arr[0];
            for (int i = 0; i < n; i++)
            {
                for (int a = 1; a < n; a++)
                {
                    if (small > Arr[a])
                    {
                        small = Arr[a];
                        holderA = a;
                    }
                }
                Arr[holderA] = 1111111;
                holderA = 0;
                Arr1[i] = small;
                small = Arr[0];
            }
            for (int a = 0; a < n; a++)
            {
                Console.WriteLine(Arr1[a]);
            }
        }
    }
}
    

