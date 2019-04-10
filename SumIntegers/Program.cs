using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class MyMath
    {
        public int sum(string strNumbers)
        {
            int sum = 0;
            int numbers = 1;
        for (int i=0;i<strNumbers.Length;i++)
             {
                if (strNumbers[i]==' ')
                {
                    numbers++;
                }
             }
            int checkpoint = 0;
            int[] Arr = new int[numbers];
            int counter = 0;
            for (int i=0;i<strNumbers.Length-1;i++)
            {
                if (strNumbers[i+1]==' ')
                {
                    switch (i-checkpoint)
                    {
                        case 0:
                            Arr[counter] = int.Parse(strNumbers[i].ToString());
                            break;
                        case 1:
                            Arr[counter] = (int.Parse(strNumbers[i - 1].ToString()) * 10) + int.Parse(strNumbers[i].ToString());
                            break;
                        case 2:
                            Arr[counter] = (int.Parse(strNumbers[i - 2].ToString()) * 100) + (int.Parse(strNumbers[i - 1].ToString()) * 10) + int.Parse(strNumbers[i].ToString());
                            break;
                    }
                    counter++;
                    checkpoint = i + 2;
                }
            }
            for (int i=0;i<numbers;i++)
            {
                sum += Arr[i];
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyMath mm = new MyMath();
            string strNumbers = Console.ReadLine();
            strNumbers += " ";
            Console.WriteLine(mm.sum(strNumbers));
        }
    }
}
