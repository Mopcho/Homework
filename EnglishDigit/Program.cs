using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class Program
    {
        public static int GetLastDigit(int number)
        {
            int x = number % 10;

            return x;
        }
        public static string StringOutput(string numStr) {
            string x="";
            switch (numStr)
            {
                case "0":
                    x = "zero";
                    break;
                case "1":
                     x = "one";
                    break;
                case "2":
                     x = "two";
                    break;
                case "3":
                     x = "three";
                    break;
                case "4":
                     x = "four";
                    break;
                case "5":
                   x = "five";
                    break;
                case "6":
                    x = "six";
                    break;
                case "7":
                    x = "seven";
                    break;
                case "8":
                    x = "eight";
                    break;
                case "9":
                    x = "nine";
                    break;
            }
            return x;
            }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numStr = GetLastDigit(number).ToString();
            Console.WriteLine(StringOutput(numStr));
        }
    }
}
