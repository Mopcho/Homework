using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int sum = 0;
            for (int i=0;i<str.Length;i++)
            {
                sum = sum + (int)str[i];
            }
            Console.WriteLine(sum);
        }
    }
}
