using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveSortedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();
            string holder;
            using (StreamReader sr=new StreamReader(file1))
            {
                holder = sr.ReadToEnd();
            }
            string[] names = holder.Split('\n');
            for (int i=1;i<names.Length;i++)
            {
                names = names.OrderBy(x => x).ToArray();
            }
            using (StreamWriter sw = new StreamWriter(file2))
            {
                for (int i = 0; i < names.Length; i++)
                {
                    sw.WriteLine(names[i]);
                }

            }
        }
    }
}
