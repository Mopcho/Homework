using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] Arr = new string[n];
            int[] stringLengths = new int[n];
            string[] sortedArr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Arr[i] = Console.ReadLine();
            }
        
         
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sortedArr[i]);
            }
        }
    }
}
