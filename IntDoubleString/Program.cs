using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "integer":
                    int integer = int.Parse(Console.ReadLine());
                    integer++;
                    Console.WriteLine(integer);
                        break;
                case "real":
                    double real = double.Parse(Console.ReadLine());
                    real++;
                    Console.WriteLine(real);
                    break;
                    

                case "string":
                    string string1 = Console.ReadLine();
                    Console.WriteLine(string1+"*");
                    break;
            }
            
        }
    }
}
