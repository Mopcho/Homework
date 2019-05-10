using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string file1 = Console.ReadLine();
            string fileText;
            using (StreamReader sr=new StreamReader(file))
            {
                fileText = sr.ReadToEnd();
            }
            string[] lines = fileText.Split('\n');
            using (StreamWriter sw=new StreamWriter(file1))
            {
              for (int i=0;i<lines.Length;i++)
                {
                    sw.WriteLine("{0} {1}", i, lines[i]);
                }
            }
        }
    }
}
