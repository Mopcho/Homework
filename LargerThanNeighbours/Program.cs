using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class Program
    {
        public static void CheckArr(int[] Arr,int n)
        {
            int counter = 1;
            bool check = true;
            int counter3 = 0;
            while (check==true)
            {
                if (Arr[counter]>Arr[counter-1] && Arr[counter]>Arr[counter+1])
                {
                    counter3++;
                }
               
                counter=counter+2;
                if (counter>n)
                {
                    check = false;
                }

            }
            Console.WriteLine(counter3);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
           
            for (int i=0;i<n;i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            CheckArr(Arr, n);
        }
    }
}
