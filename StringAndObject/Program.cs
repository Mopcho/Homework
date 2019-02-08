using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello ";
            string world = "world";
            object helloWorldObj = hello + world;
            string helloWorld = helloWorldObj.ToString();
            Console.WriteLine(helloWorld);
            Console.ReadLine();
        }
    }
}
