using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class Program
    {
        public static int FirstInvertSum(int[] Arr1,int indexOne)
        {
            int sum=0;
            string holder = "";
            int invertedCounter = indexOne-1;
            for (int i=0;i<indexOne;i++,invertedCounter--)
            {
                holder += Arr1[invertedCounter].ToString();
            }
            sum = int.Parse(holder);
         
            return sum;
        }
        public static int SecondInvertSum(int[] Arr2,int indexTwo)
        {
            int sum = 0;
            string holder = "";
            int invertedCounter = indexTwo - 1;
            for (int i = 0; i < indexTwo; i++, invertedCounter--)
            {
                holder += Arr2[invertedCounter].ToString();
            }
            sum = int.Parse(holder);
       
            return sum;
           
        }
        public static void LastInvert(int invertedSum)
        {
            string a = invertedSum.ToString();
            int invertedCounter = a.Length-1;
            string b = "";
            for (int i=0;i<a.Length;i++,invertedCounter--)
            {
                b += a[invertedCounter];
            }
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            int indexOne = int.Parse(Console.ReadLine());
            int indexTwo = int.Parse(Console.ReadLine());
            int[] Arr1 = new int[indexOne];
            int[] Arr2 = new int[indexTwo];
            for (int i=0;i<indexOne;i++)
            {
                Arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i=0;i<indexTwo;i++)
            {
                Arr2[i] = int.Parse(Console.ReadLine());
            }
          
            int invertedSum=FirstInvertSum(Arr1,indexOne) + SecondInvertSum(Arr2,indexTwo);
            LastInvert(invertedSum);

        }
    }
}
