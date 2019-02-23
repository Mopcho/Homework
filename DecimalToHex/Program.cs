using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            string holder = "";
            int remainder;
            int counter = 0; 
            for (int i = 0; dec >= 1; i++,counter++)
            {
                remainder = dec % 16;
                dec = dec / 16;
                switch (remainder)
                {
                    case 10:
                        holder += "A";
                        break;
                    case 11:
                        holder += "B";
                        break;
                    case 12:
                        holder += "C";
                        break;
                    case 13:
                        holder += "D";
                        break;
                    case 14:
                        holder += "E";
                        break;
                    case 15:
                        holder += "F";
                        break;
                    default:
                        holder += remainder.ToString();
                        break;

                }


            }
            string invertedHolder = "";
            for (int a = holder.Length-1; a >= 0;a--)
            {
                invertedHolder += holder[a];

            }
            Console.WriteLine(invertedHolder);
        }
    }
}
