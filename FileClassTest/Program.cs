using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
           string text= File.ReadAllText(file);
            string[] arr = text.Split('\n');
            File.WriteAllText(file,arr.Length.ToString());
        }
    }
}
