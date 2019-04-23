using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            string tester = "";
            string holder = "";
            string sub = "";
            for (int i=0;i<words.Length;i++)
            {
                sub = words[i];
                for (int a=words[i].Length-1;a>=0;a--)
                {
                    tester += sub[a];
                }
                if (tester==words[i])
                {
                    holder += " " + words[i];    
                }
                tester = "";
            }
            Console.WriteLine(holder);
        }
    }
}
