using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int nUmBeR = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:x}     {1:d}         {2}%         {3:E2}",nUmBeR,nUmBeR,nUmBeR,nUmBeR);
        }
    }
}