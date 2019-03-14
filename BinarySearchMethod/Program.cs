using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Arr = new int[2];
            for (int i=0;i<Arr.Length;i++)
            {
                
                    Arr[i] = int.Parse(Console.ReadLine());
             
            }
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Array.BinarySearch(Arr, n));
        }
    }
}
