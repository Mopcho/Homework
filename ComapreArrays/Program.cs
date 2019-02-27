using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComapreArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Arr1 = new int[n];
            int[] Arr2 = new int[n];
            int c = 0;
            for (int i=0;i<n;i++)
            {
                Arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int a = 0; a <n; a++)
            {
                Arr2[2] = int.Parse(Console.ReadLine());
            }
            for (int b=0;b<n;b++)
            {
                if (Arr1[b]!=Arr2[b])
                {
                    c++;
                    break;
                }
            }
            if (c>0)
            {
                Console.WriteLine("Not Equal");

            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
