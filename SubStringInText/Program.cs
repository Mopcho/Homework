using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringInText
{
    class Program
    {
        public static int countWordInText(string text, string word)
        {
            int count = 0;
            int wordLength = word.Length;
            int textLength = text.Length;
            string checker = "";
            for (int i=0;i<textLength;i++)
            {
                if (textLength-i<=word.Length-1)
                {

                }
                else
                {
                    for (int a=i;a<i+word.Length;a++)
                    {
                        checker += text[a];
                    }
                    if (checker==word)
                    {
                        count++;
                    }
                    checker = "";
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            Console.WriteLine(countWordInText(text,word));
        }
    }
}
