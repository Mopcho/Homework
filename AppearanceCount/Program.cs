using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Program
    {
      public  static int[] FillArray(int n, int[] Arr)
        {
            Arr = new int[n];
            for (int i=0;i<n;i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            return Arr;
        }
        public static int CountNumber(int n,int number,int[] Arr)
        {
            int counter = 0;
            for (int i=0;i<n;i++)
            {
                if (Arr[i]==number)
                {
                    counter++;
                   
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            int number = int.Parse(Console.ReadLine());
            Arr=FillArray(n,Arr);
            
            Console.WriteLine(CountNumber(n,number,Arr));

        }
    }
}
