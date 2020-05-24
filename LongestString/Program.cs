using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[] {"aaaaaaaaaa","bbbbbbbb","ertwert","Looooooooooooooooong"};
            string longestStrr = strArr
                .OrderByDescending(x => x.Length)
                .Select(x=>x).ToArray()[0];

            Console.WriteLine(longestStrr);
               
        }
    }
}
