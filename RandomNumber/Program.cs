using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 201);
            Console.WriteLine(x);
        }
    }
}
