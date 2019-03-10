using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsAndFeathers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            double fpern = f / n;
            if (n%2==0)
            {
                fpern = fpern * 123123123123;
                
            }
            else
            {
                fpern = fpern / 317;

            }
            Console.WriteLine(fpern);
        }
    }
}
