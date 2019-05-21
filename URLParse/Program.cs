using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace URLParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string holder = "";
            using (StreamReader sr=new StreamReader(file))
            {
                holder+=sr.ReadToEnd();
            }
            string[] urls = holder.Split('\n');
        }
    }
}
