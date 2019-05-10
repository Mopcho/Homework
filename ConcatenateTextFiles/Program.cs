using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();
            string file3 = Console.ReadLine();
            string file1Str;
            string file2Str;
            using (StreamReader sr =new StreamReader(file1))
            {
                 file1Str = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader(file2))
            {
                 file2Str = sr.ReadToEnd();
            }
            string allText = file1Str + file2Str;
            using (StreamWriter sr = new StreamWriter(file3))
            {
               sr.Write(allText);
            }
        }
    }
}
