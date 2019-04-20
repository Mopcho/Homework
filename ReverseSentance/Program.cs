using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentance
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance = Console.ReadLine();
            string[] words = sentance.Split(' ');
            string holder = "";
            for (int i=words.Length-1;i>=0;i--)
            {
                holder += " " + words[i];
            }
            
            Console.WriteLine(holder);
        }
    }
}
