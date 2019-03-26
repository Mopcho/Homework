using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class Program
    {
        public static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
    }
}
