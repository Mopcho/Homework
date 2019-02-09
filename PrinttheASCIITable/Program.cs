using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinttheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            for (int i=33;i<126;i++)
            {
                a = (char)i;
                Console.Write(a);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
