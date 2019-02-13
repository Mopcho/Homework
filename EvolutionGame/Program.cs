using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionGame
{
    class Program
    {
        public static void CursorUpPlayMenu(string easy,string normal,string hard,string cursor,int counterPlayMenu )
        {

        
        
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (counterPlayMenu)
            {
                case 1:
                    Console.WriteLine(easy.PadLeft(20, ' '));
                    Console.WriteLine(normal.PadLeft(22, ' '));
                    Console.Write(hard.PadLeft(20, ' '));
                    Console.WriteLine(cursor.PadLeft(6, ' '));

                    break;
                case 2:
                    Console.WriteLine(easy.PadLeft(20, ' '));
                    Console.Write(normal.PadLeft(22, ' '));
                    Console.WriteLine(cursor.PadLeft(4, ' '));
                    Console.WriteLine(hard.PadLeft(20, ' '));
                    break;
                case 3:
                    Console.Write(easy.PadLeft(20, ' '));
                    Console.WriteLine(cursor.PadLeft(6, ' '));
                    Console.WriteLine(normal.PadLeft(22, ' '));
                    Console.WriteLine(hard.PadLeft(20, ' '));
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));


        }
        public static void CursorDownPlayMenu(string easy, string normal, string hard, string cursor,int counterPlayMenu)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (counterPlayMenu)
            {
                case 1:
                    Console.WriteLine(easy.PadLeft(20, ' '));
                    Console.WriteLine(normal.PadLeft(22, ' '));
                    Console.Write(hard.PadLeft(20, ' '));
                    Console.WriteLine(cursor.PadLeft(6, ' '));

                    break;
                case 2:
                    Console.WriteLine(easy.PadLeft(20, ' '));
                    Console.Write(normal.PadLeft(22, ' '));
                    Console.WriteLine(cursor.PadLeft(4, ' '));
                    Console.WriteLine(hard.PadLeft(20, ' '));
                    break;
                case 3:
                    Console.Write(easy.PadLeft(20, ' '));
                    Console.WriteLine(cursor.PadLeft(6, ' '));
                    Console.WriteLine(normal.PadLeft(22, ' '));
                    Console.WriteLine(hard.PadLeft(20, ' '));
                    break;

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));

        }
        public static void PressPlay(string easy,string normal,string hard,string cursor)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(easy.PadLeft(20,' '));
            Console.WriteLine(cursor.PadLeft(6, ' '));
            Console.WriteLine(normal.PadLeft(22, ' '));
            Console.WriteLine(hard.PadLeft(20, ' '));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));
            int i = 0;
            int counterPlayMenu = 3;
            while ( i<10) {
                ConsoleKeyInfo KeyInput = Console.ReadKey(true);
                if (KeyInput.Key == ConsoleKey.Backspace)
                {
                    i = i + 10;
                }
                if (KeyInput.Key == ConsoleKey.UpArrow)
                {
                    if (counterPlayMenu == 3)
                    {
                        
                    }
                    else
                    {
                        counterPlayMenu++;
                    }
                    Console.Clear();
                    CursorUpPlayMenu(easy,normal,hard,cursor,counterPlayMenu);
                }
                if (KeyInput.Key == ConsoleKey.DownArrow)
                {
                    if (counterPlayMenu == 1)
                    {

                    }
                    else
                    {
                        counterPlayMenu--;
                    }
                    Console.Clear();
                    CursorDownPlayMenu(easy,normal,hard,cursor,counterPlayMenu);
                }
                if (KeyInput.Key == ConsoleKey.Enter)
                {

                }

            }

            
        }
        public static void PressOptions()
        {

        }
        public static void PressExit()
        {
            Environment.Exit(0);
        }
        public static void CursorUp(int counter,string cursor,string play,string options,string exit)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));
            Console.ForegroundColor = ConsoleColor.Yellow;

            switch (counter)
            {
                case 1:
                    Console.WriteLine(play.PadLeft(20, ' '));
                    Console.WriteLine(options.PadLeft(23, ' '));
                    Console.Write(exit.PadLeft(20, ' '));
                    Console.WriteLine(cursor.PadLeft(6,' '));

                    break;
                case 2:
                    Console.WriteLine(play.PadLeft(20, ' '));
                    Console.Write(options.PadLeft(23, ' '));
                    Console.WriteLine(cursor.PadLeft(3, ' '));
                    Console.WriteLine(exit.PadLeft(20, ' '));
                    break;
                case 3:
                    Console.Write(play.PadLeft(20, ' '));
                    Console.WriteLine(cursor.PadLeft(6, ' '));
                    Console.WriteLine(options.PadLeft(23, ' '));
                    Console.WriteLine(exit.PadLeft(20, ' '));
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));




        }
        public static void CursorDown(int counter, string cursor, string play, string options, string exit)
        {


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (counter == 1)
            {
                Console.WriteLine(play.PadLeft(20, ' '));
                Console.WriteLine(options.PadLeft(23, ' '));

                Console.Write(exit.PadLeft(20, ' '));
                Console.WriteLine(cursor.PadLeft(6, ' '));


            }
            else if (counter == 2)
            {
                Console.WriteLine(play.PadLeft(20, ' '));
                Console.Write(options.PadLeft(23, ' '));
                Console.WriteLine(cursor.PadLeft(3, ' '));
                Console.WriteLine(exit.PadLeft(20, ' '));
                
            }
            else if (counter==3)
            {
                Console.Write(play.PadLeft(20, ' '));
                Console.WriteLine(cursor.PadLeft(6, ' '));
                Console.WriteLine(options.PadLeft(23, ' '));
                Console.WriteLine(exit.PadLeft(20, ' '));
               
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));



        }
        static void Main(string[] args)
        {
            string easy = "Easy";
            string normal = "Normal";
            string hard = "Hard";
            string cursor = "@";
            string play = "Play";
            string options = "Options";
            string exit = "Exit";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40,'-'));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} {1}",play.PadLeft(20,' '),cursor.PadLeft(5,' '));
            Console.WriteLine(options.PadLeft(23, ' '));
            Console.WriteLine(exit.PadLeft(20, ' '));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-".PadRight(40, '-'));
            int counter = 3;
            int y=0;
            int i = 0;
            while ( i<10) {
                ConsoleKeyInfo KeyInput = Console.ReadKey(true);
           
              
                if (KeyInput.Key == ConsoleKey.UpArrow)
                {
                    if (counter == 3)
                    {

                    }
                    else
                    {
                        counter++;
                    }

                    Console.Clear();
                   
                   
                    CursorUp(counter,cursor,play,options,exit);


                }
              else  if (KeyInput.Key == ConsoleKey.DownArrow)
                {

                    if (counter == 1)
                    {

                    }
                    else
                    {
                        counter--;
                    }

                    Console.Clear();
                    
                    
                    CursorDown(counter, cursor, play, options, exit);


                }
                if (KeyInput.Key == ConsoleKey.Enter)
                {
                    switch (counter)
                    {
                        case 1:
                            Console.Clear();
                            PressExit();
                            break;
                        case 2:
                            Console.Clear();
                            PressOptions();
                            break;
                        case 3:
                            Console.Clear();
                            PressPlay(easy,normal,hard,cursor);
                            break;


                    }
                }

            }




        }
    }
}
