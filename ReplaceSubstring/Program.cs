using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();
            string finish = "finish";
            string holder;
            using (StreamReader sr = new StreamReader(file1))
            {
                holder = sr.ReadToEnd();
            }
            string[] words = holder.Split(' ');
            string sentances = "";
            string x;
            for (int i=0;i<words.Length;i++)
            {
                if (words[i]=="start")
                {
                    x = "finish";
                }
                else
                {
                    x = words[i];
                }
                sentances += " " + x;
            }
            using (StreamWriter sw=new StreamWriter(file2))
            {
                sw.Write(sentances);
            }

        }
    }
}
