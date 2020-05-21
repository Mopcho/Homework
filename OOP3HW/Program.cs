using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3HW
{
    class Program
    {
        public static string[] Sort(string[] names)
        {
            string[] sortedStr = names
                 .Select(x => x)
                 .Where(name => (int)name[0] < (int)name.Split(' ')[1][0]).ToArray();
                 
                 
            return sortedStr;  
        }
        static void Main()
        {
            var names = new string[] {"Stoyan Kolev","Valeri Petkov", "aaaa bbbb", "bbbb aaaaa"};
            Console.WriteLine(string.Join(" " , Sort(names))); 
        }
    }
}
