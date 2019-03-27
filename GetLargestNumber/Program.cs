using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class Program
    {
        public static void GetMax(int a,int b,int c)
        {
       if (a>b && a>c)
            {
                Console.WriteLine(a);
            }
       else if (b>a && b>c)
            {
                Console.WriteLine(b);
            }
       else if (c>a && c>b)
            {
                Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GetMax(a,b,c);
        }
    }
}
