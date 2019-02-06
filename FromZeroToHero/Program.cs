using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToHero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=1;i<=n;i++)
            {
                Console.Write("{0} ",i);
            }
        }
    }
}
