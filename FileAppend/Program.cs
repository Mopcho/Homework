using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileAppend
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string contentStr = Console.ReadLine();
            string[] content = contentStr.Split(' ');
            File.AppendAllLines(path, content);
        }
    }
}
