using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsosclecTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "©";
            int steps = int.Parse(Console.ReadLine());
            int counter = steps - 1;
            int counter2 = 0;
            int spacesFirst = 1;
            for (int i = 0; i < steps+((steps/2)-2); i++, counter--)
            {
                Console.WriteLine();
                if (i == steps + ((steps / 2) - 2) - 1)
                {
                    for (int c = 0; c < steps; c++)
                    {
                        Console.Write("{0} ", x);
                    }

                    break;
                }
                for (int a = 0; a < counter; a++)
                {
                    Console.Write(" ");
                    spacesFirst++;

                }
                Console.Write(x);
                if (i > 0)
                {
                    for (int b = 0; b < counter2-1; b++)
                    {
                        Console.Write(" ");


                    }
                    Console.Write(x);
                }
                counter2 = counter2 + 2;
                
                Console.WriteLine();
            }
        }
    }
}
