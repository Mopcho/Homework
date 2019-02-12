using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Program
    {
       
        public static void playerMoveRight(string a,int spaces,int toY,int toX)
        {
            for (int y = 0; y < toX; y++)
            {
                Console.WriteLine();

            }
            for (int x = 0; x < toY; x++)
            {
                Console.Write(" ");
            }
            a.PadLeft(spaces, ' ');
            
            Console.Write(a);
       
        }
        public static void playerMoveLeft(string a, int spaces, int toY, int toX)
        {
            for (int y = 0; y < toX; y++)
            {
                Console.WriteLine();
            }
            for (int x = 0; x < toY; x++)
            {
                Console.Write(" ");
            }
            a.PadLeft(spaces, ' ');

            Console.Write(a);
        }
        public static void playerMoveUp(string a, int spaces, int toY, int toX)
        {
            for (int y = 0; y < toX; y++)
            {
                Console.WriteLine();
            }
            for (int x = 0; x < toY; x++)
            {
                Console.Write(" ");
            }
            a.PadLeft(spaces, ' ');

            Console.Write(a);
        }
        public static void playerMoveDown(string a, int spaces, int toY, int toX)
        {
            for (int y = 0; y < toX; y++)
            {
                Console.WriteLine();
            }
            for (int x = 0; x < toY; x++)
            {
                Console.Write(" ");
            }
            a.PadLeft(spaces, ' ');

            Console.Write(a);
        }
        static void Main(string[] args)
        {
            int spaces = 0;
            for (int y=0;y<10;y++)
            {
                Console.WriteLine();
            }
            for (int x=0;x<20;x++)
            {
                Console.Write(" ");
            }
            string a = "@";
            Console.Write(a);
          
            int i = 0;
            int toX = 20;
            int toY = 10;
            int counter = 0;
            while (i<10)
            {

                Thread.Sleep(150);
                ConsoleKeyInfo KeyInput = Console.ReadKey(true);
                
               
                if (KeyInput.Key == ConsoleKey.RightArrow)
                {

                    Console.Clear();
                    toX++;
                    spaces++;
                    playerMoveRight(a,spaces,toX,toY);
                    

                }
                if (KeyInput.Key == ConsoleKey.LeftArrow)
                {

                    Console.Clear();
                    toX--;
                    spaces++;
                    playerMoveLeft(a, spaces, toX, toY);


                }
                if (KeyInput.Key == ConsoleKey.UpArrow)
                {

                    Console.Clear();
                    toY--;
                    spaces++;
                    playerMoveRight(a, spaces, toX, toY);


                }
                if (KeyInput.Key == ConsoleKey.DownArrow)
                {

                    Console.Clear();
                    toY++;
                    spaces++;
                    playerMoveRight(a, spaces, toX, toY);


                }

            }

        }
    }
}
