using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Program
    {
        static bool isCorrect(string str) {
            bool isTrue = false;
            int balancer = 0;
            for (int i=0;i<str.Length;i++)
            {
                if (str[i]=='(')
                {
                    balancer++;
                }
                if (str[i]==')')
                {
                    balancer--;
                }
            }
            if (balancer==0)
            {
                isTrue = true;
            }
            return isTrue;
            }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(isCorrect(str));
        }
    }
}
