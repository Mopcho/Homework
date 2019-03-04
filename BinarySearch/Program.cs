﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            for (int i=0;i<n;i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            int middle = n / 2;
            int index = 0;
            for (int i=0;i<n;i++)
            {
                if (x==Arr[middle])
                {
                    index = middle;
                    break;
                }
                else if (x<Arr[middle])
                {
                 
                    middle = middle / 2;
                }
                else if (x>Arr[middle])
                {
                   
                    middle = (middle / 2) + middle;
                }
            }
            Console.WriteLine(index);

        }
    }
}
