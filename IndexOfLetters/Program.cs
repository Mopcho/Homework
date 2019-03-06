using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string word = Console.ReadLine();
            for (int i=0;i<word.Length;i++)
            {
                for (int a=0;a<25;a++)
                {
                    if (alphabet[a]==word[i])
                    {
                        Console.WriteLine(a+1);
                        a = 30;
                    }
                }
            }
        }
    }
}
