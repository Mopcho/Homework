using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileContents
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Console.ReadLine();
                Console.WriteLine(System.IO.File.ReadAllText(path));
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Directorty");
            }
        }
    }
}
