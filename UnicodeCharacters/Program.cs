using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string holder = "";
            for (int i=0;i<word.Length;i++)
            {
                holder+="\\u00";
                holder +=string.Format("{0:X}",(int)word[i]);
            }
            Console.WriteLine(holder);
        }
    }
}
