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
            switch (card[0])
            {
                case 'A':
                    for (int i = 0; i < 11; i++)
                    {
                        for (int a = 0; a < 4; a++)
                        {
                            switch (a)
                            {
                                case 1:
                                    Console.Write("{0} of {1}", a, spades);
                                    break;
                                case 2:
                                    Console.Write("{0} of {1}", a, clubs);
                                    break;
                                case 3:
                                    Console.Write("{0} of {1}", a, hearth);
                                    break;
                                case 4:
                                    Console.Write("{0} of {1}", a, diamonds);
                                    break;


                            }
                            Console.WriteLine();

                        }
                    }
                    break;
                default:
                    char[] charArr = card.ToCharArray();


                    int cardNum = int.Parse(charArr[0].ToString());
                    for (int i = 0; i < cardNum; i++)
                    {
                        for (int a = 0; a < 4; a++)
                        {
                            switch (a)
                            {
                                case 1:
                                    Console.Write("{0} of {1}", a, spades);
                                    break;
                                case 2:
                                    Console.Write("{0} of {1}", a, clubs);
                                    break;
                                case 3:
                                    Console.Write("{0} of {1}", a, hearth);
                                    break;
                                case 4:
                                    Console.Write("{0} of {1}", a, diamonds);
                                    break;


                            }
                        }
                    }
                    break;




            }
        }
    }
}
