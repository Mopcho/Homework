using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string start = "<upcase>";
            string end = "</upcase>";
            string[] words = text.Split(' ');
            int lever = 0;
            string holder = "";
            for (int i=0;i<words.Length;i++)
            {
                if (words[i]==start)
                {
                    lever++;
                }
                else if (words[i]==end)
                {
                    lever--;
                }
                if (lever==0)
                {
                    if (words[i] == start || words[i] == end)
                    {

                    }
                    else
                    {
                        holder +=" " +words[i];
                    }
                }
                else if (lever==1)
                {
                    if (words[i] == start || words[i] == end)
                    {

                    }
                    else
                    {
                        holder += " " + words[i].ToUpper();
                    }
                }
             
            }
            Console.WriteLine(holder);
        }
    }
}
