using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string holder;
            string onlyEven="";
            int counter = 1;
            using (StreamReader sr=new StreamReader(file))
            {
                holder = sr.ReadToEnd();
            }
            string[] lines = holder.Split('\n');
            for (int i=0;i<lines.Length;i++,counter++)
            {
                if (counter%2==0)
                {
                    onlyEven += lines[i]+'\n';
                }
            }
            using (StreamWriter sw=new StreamWriter(file))
            {
                sw.Write(onlyEven);
            }
        }
    }
}
