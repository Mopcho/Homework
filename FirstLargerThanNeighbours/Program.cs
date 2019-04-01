using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        public static void FirstLargerThanNeighbours(int n,int[] Arr)
        {
            int counter = -1;
            for (int i=1;i<n-1;i++)
            {
                if (Arr[i]>Arr[i+1] || Arr[i]>Arr[i-1])
                {
                    counter = i;
                    break;
                }
            }
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            FirstLargerThanNeighbours(n,Arr);
        }
    }
}
