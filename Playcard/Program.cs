using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playcard
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string cards = "23456789JQKA";
            string guess = Console.ReadLine();
            int p = 0;
            int c = 0;
            int constant = 0;
            if (guess=="10" )
            {
                Console.WriteLine("yes 10");
                p++;
            }
            if (p<1)
            {
      
                for (int i = 0; i < 12; i++)
                {
                    c++;
                    if (guess[constant] == cards[i])
                    {
                        Console.WriteLine("yes {0}", guess);
                        c = 0;
                        break;

                        


                    }


                }
                if (c > 0)
                {
                    Console.WriteLine("no {0}", guess);
                }
            }
      
            
        }
    }
}
