using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int counter = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string holder = sr.ReadToEnd();
                string[] arr = holder.Split('\n');
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }
    }
}

