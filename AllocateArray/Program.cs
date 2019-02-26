using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];
            for (int i=0;i<n;i++)
            {
                Array[i] = i * n;
            }
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("{0}", Array[i]);
            }
        }
    }
}
