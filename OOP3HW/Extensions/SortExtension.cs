using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3HW.Extensions
{
   public static class SortExtension
    {
        public static string[] Sort(string[] names)
        {
            string[] sortedStr = names
                 .Select(x => x)
                 .Where(name => (int)name[0] < (int)name.Split(' ')[1][0]).ToArray();
            return sortedStr;
        }
    }
}
