using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string invertedStr = "";
            for (int i=str.Length-1;i>=0;i--)
            {
                invertedStr += str[i];
            }
            Console.WriteLine(invertedStr);
        }
    }
}
