﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string letter = Console.ReadLine();
            int[,] Arr = new int[n, n];
            int c = 1;
            if (letter == "a")
            {
                for (int i = 0; i < n; i++)
                {
                    for (int a = 0; a < n; a++)
                    {
                        Arr[a, i] = c;
                        c++;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int a = 0; a < n; a++)
                    {
                        Console.Write("{0} ", Arr[i, a]);
                    }
                    Console.WriteLine();
                }
            }
            else if (letter=="b")
            {
               int counter = 2;
                for (int i = 0; i < n; i++,counter++)
                {
                    if (i % 2 == 0)
                    {
                        for (int a = 0; a < n; a++)
                        {
                            Arr[a, i] = c;
                            c++;
                        }
                    }
                    else
                    {
                        for (int a=n-1;a>=0;a--)
                        {
                            Arr[a, i] = c;
                            c++;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int a = 0; a < n; a++)
                    {
                        Console.Write("{0} ", Arr[i, a]);
                    }
                    Console.WriteLine();
                }

            }
            else if (letter=="c")
            {
                int counterRow = n-1;
                int counterLine = 0;
                int counter = 1;
                int number = 2;
                
                int fakeN =1;
                  while (counter<4)
                    {
                    for (int i=0;i<counter;i++)
                    {
                        Arr[counterRow,counterLine]= number;
                        number++;
                    }
                   
                    counter++;
                    }
                  while (counter>=4)
                {

                }

               
                for (int i = 0; i < n; i++)
                {
                    for (int a = 0; a < n; a++)
                    {
                        Console.Write("{0} ", Arr[i, a]);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
