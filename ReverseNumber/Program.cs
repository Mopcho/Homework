using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        public static void InvertDigit(double n)
        {
            string holder = n.ToString();
            int counter = holder.Length-1;
            string holder2 = "";
            for (int i = 0; i < holder.Length; i++, counter--)
            {
                holder2 += holder[counter];
            }
            Console.WriteLine(holder2);
            
              
            
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            InvertDigit(n);
        }
    }
}
