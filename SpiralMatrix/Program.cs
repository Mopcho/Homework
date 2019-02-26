using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int mn = int.Parse(Console.ReadLine());
            int y = 1;
            int x = 1;
            int number = 1;
            int fakeA = 0;
            for (int i=0;i<mn;i++,y++)
            {
                
                for (int a=0;a<mn;a++,number++,fakeA++,x++)
                {
                    Console.Write("{0} ", number);
                    

                }
                number = 1;
                number = ((number + (mn - y)) + mn) + (mn - y);
                
                Console.WriteLine();
            }
        }
    }
}
