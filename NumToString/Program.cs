using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] Arr = text.Split(' ');
            string holder = "";
            for (int i=0;i<Arr.Length;i++)
            {
                switch (Arr[i])
                {
                    case "one":
                        holder += " " + '1' + " ";
                        break;
                    case "two":
                        holder += " " + '2' + " ";
                        break;
                    case "three":
                        holder += " " + '3' + " ";
                        break;
                    case "four":
                        holder += " " + '4' + " ";
                        break;
                    case "five":
                        holder += " " + '5' + " ";
                        break;
                    case "six":
                        holder += " "+'6'+" ";
                        break;
                    case "seven":
                        holder += " " + '7' + " ";
                        break;
                    case "eight":
                        holder += " " + '8' + " ";
                        break;
                    case "nine":
                        holder += " " + '9' + " ";
                        break;
                    default:
                        holder += " "+Arr[i]+" ";
                        break;
                }
            }
            Console.WriteLine(holder);
        }
    }
}
