using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string file2 = Console.ReadLine();
            string holder;
            string cleanSentance = "";
            using (StreamReader sr=new StreamReader(file))
            {
                holder = sr.ReadToEnd();
            }
            string[] words = holder.Split(' ');
            for (int i=0;i<words.Length;i++)
            {
                if (words[i].Contains("Test") || words[i].Contains("test")) 
                {

                }
                else
                {
                    cleanSentance +=" "+words[i];
                }
            }
            using (StreamWriter sw=new StreamWriter(file2))
            {
                sw.Write(cleanSentance);
            }
        }
    }
}
