using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string holder = text[0].ToString();
            char curr=text[0];
            for (int i=0;i<text.Length;i++)
            {
                curr = text[i];
                if (i+1<=text.Length-1)
                {
                    curr = text[i+1];
                }
               
                if (curr!=text[i])
                {
                    holder += curr;
                }
              
                
            }
            Console.WriteLine(holder);
        }
    }
}
