using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance = Console.ReadLine();
            string words = Console.ReadLine();
            string[] arrWords = words.Split(' ');
            string[] arrSentance = sentance.Split(' ');
            string holder = "";
            for (int i=0;i<arrSentance.Length;i++)
            {
                for (int a = 0; a < arrWords.Length; a++) {
                    if (arrSentance[i] ==arrWords[a])
                    {
                        for (int c = 0; c < arrSentance[i].Length; c++) {
                            holder = holder +"*" ;
                        }
                        holder += " ";
                    }
                    else
                    {
                        holder += " "+arrSentance[i];
                    }
                        }
            }
            Console.WriteLine(holder);

        }
    }
}
