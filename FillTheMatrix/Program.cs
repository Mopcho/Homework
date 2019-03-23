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
                int number = 1;
                int invertCounter = 1;
                int counter1 =1;
                  while (counter<n)
                    {
                    for (int i=0;i<counter;i++,counter1++)
                    {
                        Arr[counterRow,counterLine]= number;
                        counterLine++;
                        counterRow++;
                        number++;
                    }
                    counterRow = counterRow - counter1;
                    counterLine = 0;
                    counter1 = 1;

                    counter++;
                    }
                int fakeCounter = 0;
                int lineHolder = 1;
                  while (fakeCounter<n)
                {
                    for (int i = 0; i <counter; i++,counter1++)
                    {
                        if (i==0)
                        {  
                            lineHolder = counterLine;
                        }
                        Arr[counterRow, counterLine] = number;
                        counterLine++;
                        counterRow++;
                        number++;
                    }
                    counterRow = 0;
                    if (counter==n)
                    {
                        counterLine = 1;
                    }
                    else
                    {
                        counterLine = lineHolder +1;
                    }
                    invertCounter--;
                    counter1 = 1;
                    counter--;
                    fakeCounter++;
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












            else if (letter=="d")
            {
                int checkpoint = n - 2;
                int steps = 1;
                int line = 1;
                int row = n-1;
                int number = n+1;
               
                    for (int a = 0; a < n; a++)
                    {
                        Arr[a, 0] = a+1;
                        
                    }
              




                   

                while (number!=n*n) { 


                    for (int a = 0; a < checkpoint; a++)
                    {
                       
                      if (steps==1)
                        {
                            Arr[row, line] = number;
                            line++;
                            number++;

                            if (number == n * n)
                            {
                                break;
                            }
                        }
                      else if (steps==2)
                        {
                            Arr[row, line] = number;
                            row--;
                            number++;

                            if (number == n * n)
                            {
                                break;
                            }
                        }
                      else if (steps==3)
                        { 
                            Arr[row, line] = number;
                            line--;
                            number++;
                            if (a==checkpoint-1)
                            {
                                checkpoint--;
                            }
                            if (number == n * n)
                            {
                                break;
                            }

                        }
                      else if (steps==4)
                        {  
                            Arr[row, line] = number;
                            row++;
                            number++;

                            if (a==checkpoint-1)
                            {
                                steps = 0;
                               
                            }

                            if (number == n * n)
                            {
                                break;
                            }
                        }
                    }
                    steps++;
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
