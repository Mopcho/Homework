using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeck
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            string spades = "spades";
            string clubs = "club";
            string hearth = "hearth";
            string diamonds = "diamonds";
            string aCard = "A";
            int counter = 2;
            switch (card[0])
            {
                case 'A':
                    for (int i = 2; i < 11; i++)
                    {
                                    Console.Write(" {0} of {1} ", i, spades);
                                    Console.Write(" {0} of {1} ", i, clubs);
                                    Console.Write(" {0} of {1} ", i, hearth);
                                    Console.Write(" {0} of {1} ", i, diamonds);
                                    Console.WriteLine();
                    }
                    Console.Write(" {0} of {1} ", aCard, spades);
                    Console.Write(" {0} of {1} ", aCard, clubs);
                    Console.Write(" {0} of {1} ", aCard, hearth);
                    Console.Write(" {0} of {1} ", aCard, diamonds);
                    Console.WriteLine();
                    break;
                default:
                    char[] charArr = card.ToCharArray();
                    int cardNum = int.Parse(charArr[0].ToString());
                    Console.WriteLine(cardNum);
                    for (int i = 2; i < cardNum; i++)
                    {
                                    Console.Write(" {0} of {1} ", i, spades);
                                    Console.Write(" {0} of {1} ", i, clubs);
                                    Console.Write(" {0} of {1} ", i, hearth);
                                    Console.Write(" {0} of {1} ", i, diamonds);
                                    Console.WriteLine();   
                    }
                    break;
            }
        }
    }
}
