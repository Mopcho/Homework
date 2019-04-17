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
            string[] arrForbiddenWords = words.Split(' ');
            string[] arrWords = sentance.Split(' ');
            string holder = "";
            string stars = "";
            int lever = 0;
            for (int i=0;i<arrWords.Length;i++)
            {
                for (int a = 0; a < arrForbiddenWords.Length; a++)
                {
                    if (arrWords[i] == arrForbiddenWords[a])
                    {
                        for (int b = 0; b < arrForbiddenWords[a].Length; b++)
                        {
                            stars += "*";
                        }
                        holder += " "+stars;
                        stars = "";
                        lever++;
                    }
                }
                if (lever==1)
                {

                }
                else 
                {
                    holder +=" "+ arrWords[i];
                }
                lever = 0;
            }
            Console.WriteLine(holder);
        }
    }
}
