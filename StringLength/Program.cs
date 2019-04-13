using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string holder = "";
            for (int i=0;i<input.Length;i++)
            {
                if (i>19)
                {
                    holder += "*";
                }
                else
                {
                    holder += input[i];
                }
               
            }
            Console.WriteLine(holder);

        }
    }
}
