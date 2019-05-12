using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();
            string holder1;
            string holder2;
            string text = "";
            bool lever = true;
            using (StreamReader sr=new StreamReader(file1))
            {
                holder1 = sr.ReadToEnd();
            }
            using (StreamReader sr1=new StreamReader(file2))
            {
                holder2 = sr1.ReadToEnd();
            }
            string[] words1 = holder1.Split(' ');
            string[] words2 = holder2.Split(' ');
            for (int i=0;i<words2.Length;i++)
            {
                for (int a=0;a<words1.Length;a++)
                {
                    if (words1[a]==words2[i])
                    {
                        lever = false;
                        Console.WriteLine("asda");
                        break;
                    }
                  
                }
                if (lever)
                {
                    text += " " + words2[i];
                }
                lever = true;
            }
            using (StreamWriter sw = new StreamWriter(file2))
            {
                sw.Write(text);
            }
        }
    }
}
