using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            string holder = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains('@') && words[i].Contains('.'))
                {
                    if (!(words[i].IndexOf('.') < 8 || words[i].LastIndexOfAny(new char[] { '.', '@' }) == words[i].Length - 1))
                    {
                        holder += " " + words[i];
                    }
                    
                }
            }
            string[] email = holder.Split(' ');
            for (int i=0;i<email.Length;i++)
            {
                Console.WriteLine(email[i]);
            }
        }
    }
}
