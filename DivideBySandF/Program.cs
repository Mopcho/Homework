using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBySandF
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            if (numb%5==0 && numb%7==0)
            {
                Console.WriteLine("true {0}", numb);
            }
            else
            {
                Console.WriteLine("false {0}", numb);
            }
            Console.ReadLine();
        }
    }
}
