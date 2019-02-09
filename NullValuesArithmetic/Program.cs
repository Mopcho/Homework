using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = 10;
            b = 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
