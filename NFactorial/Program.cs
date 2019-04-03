using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        public static void PrintArr(int[] Arr,int n)
        {
            for (int i = 0; i < n;i++)
            {
                Console.Write("{0} ", Arr[i]); 
            }
        }
        public static void Ascend (int[] Arr,int n)
        {
            int smallest = Arr[0];
            int smallestIndex = 0;
            int[] sortedArr = new int[n];
            for (int i=0;i<n;i++)
            {
               for (int a=0;a<n;a++)
                {
                    if (Arr[a]<smallest)
                    {
                        smallestIndex = a; 
                        smallest = Arr[a];
                    }
                }
                sortedArr[i] = Arr[smallestIndex];
                Arr[smallestIndex] = 1000;
                smallest = 1000;
            }
            PrintArr(sortedArr,n);
        }
        public static void Descend (int[] Arr,int n)
        {
            int biggest = Arr[0];
            int biggestIndex = 0;
            int[] sortedArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int a = 0; a < n; a++)
                {
                    if (Arr[a] > biggest)
                    {
                        biggestIndex = a;
                        biggest = Arr[a];
                    }
                }
                sortedArr[i] = Arr[biggestIndex];
                Arr[biggestIndex] = -1000;
                biggest = -1000; 
            }
            PrintArr(sortedArr, n);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string answer = Console.ReadLine();
            int[] Arr = new int[n];
            for (int i = 0; i < n;i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            if (answer=="A")
            {
                Ascend(Arr,n);
            }
            else if (answer=="D")
            {
                Descend(Arr,n);
            }
            
        }
    }
}
