using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConcatenateTextFilesFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();
            string file3 = Console.ReadLine();
            string text1 = File.ReadAllText(file1);
            string text2 = File.ReadAllText(file2);
            string sum = text1 + text2;
            File.WriteAllText(file3,sum);

        }
    }
}
