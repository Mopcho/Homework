using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitAsWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstLetterStr = "";
            string secondLetterStr = "";
            string firstLetter = n.ToString();
            if (n>20 && n<100)
            {
                
                switch (firstLetter[0])
                {
                   
                    case '2':
                        firstLetterStr = "twenty";
                        break;
                    case '3':
                         firstLetterStr = "thirty";
                        break;
                    case '4':
                         firstLetterStr = "fourty";
                        break;
                    case '5':
                         firstLetterStr = "fifthy";
                        break;
                    case '6':
                        firstLetterStr = "sixty";
                        break;
                    case '7':
                         firstLetterStr = "seventy";
                        break;
                    case '8':
                         firstLetterStr = "eighty";
                        break;
                    case '9':
                         firstLetterStr = "ninety";
                        break;
                }
                switch (firstLetter[1])
                {
                    case '1':
                        secondLetterStr = "one";
                        break;
                    case '2':
                        secondLetterStr = "two";
                        break;
                    case '3':
                        secondLetterStr = "three";
                        break;  
                    case '4':
                        secondLetterStr = "four";
                        break;
                    case '5':
                        secondLetterStr = "five";
                        break;
                    case '6':
                        secondLetterStr = "six";
                        break;
                    case '7':
                        secondLetterStr = "seven";
                        break;
                    case '8':
                        secondLetterStr = "eight";
                        break;
                    case '9':
                        secondLetterStr = "nine";
                        break;
                }
                Console.WriteLine(firstLetterStr + secondLetterStr); 
            }
            else if (n<=20 && n>10)
            {
                switch (firstLetter)
                {
                    case "10":
                        Console.WriteLine("ten");
                        break;
                    case "11":
                        Console.WriteLine("Eleven");
                        break;
                    case "12":
                        Console.WriteLine("Twelve");
                        break;
                    case "13":
                        Console.WriteLine("thirteen");
                        break;
                    case "14":
                        Console.WriteLine("fourteen");
                        break;
                    case "15":
                        Console.WriteLine("fifteen");
                        break;
                    case "16":
                        Console.WriteLine("sixteen");
                        break;
                    case "17":
                        Console.WriteLine("seventeen");
                        break;
                    case "18":
                        Console.WriteLine("eighteen");
                        break;
                    case "19":
                        Console.WriteLine("nineteen");
                        break;
                    case "20":
                        Console.WriteLine("twenty");
                        break;
                }
            }
            else if (n<10 && n>0)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            }
            else if (firstLetter[1]=='0' && n>20 && n<100)
            {
                switch (firstLetterStr[0])
                {
                    case '3':
                        Console.WriteLine("thirty");
                        break;
                    case '4':
                        Console.WriteLine("fourty");
                        break;
                    case '5':
                        Console.WriteLine("fifty");
                        break;
                    case '6':
                        Console.WriteLine("sixty");
                        break;
                    case '7':
                        Console.WriteLine("seventy");
                        break;
                    case '8':
                        Console.WriteLine("eighty");
                        break;
                    case '9':
                        Console.WriteLine(" ninety");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
