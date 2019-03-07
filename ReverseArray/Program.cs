using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
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
            int[] RevArr = new int[n];
            int upCounter = 0;
            for (int i=n-1;i>=0;i--,upCounter++)
            {
                Console.WriteLine("            {0},{1}", upCounter, i);
                RevArr[upCounter] = Arr[i];
            }
            for (int i=0;i<n;i++)
            {
                Console.WriteLine(RevArr[i]);
            }
        }
    }
}
