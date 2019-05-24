using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your nickname :");
            string nickname = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("You are enjoying a beutiful morning and decide to turn on the TV* \n Press a button to continue");
            Console.ReadLine();
            Console.WriteLine("*You see the presiden giving a speech and hear that missles are going to hit your country* \n Press a button to continue");
            Console.ReadLine();
            Console.WriteLine("You panick and realize that you have about 60 sec to grab everything you need and go to the bunker \n Press a button to continue");
            Console.ReadLine();
            Console.WriteLine("You can only carry 12 items (one carriage to the bunker takes 10 secs) , up to 4 items so you must choose wisely \n Press a button to continue");
            Console.ReadLine();
            Console.WriteLine("Choose from the items below (each item can be picked more than one time) :");
            Console.WriteLine("Watter bottle 10L \n Water Bottle 5L \n Canned food \n Map \n Shotgun (Takes 3 slots) \n Radio \n Dog \n Antigas mask \n Flashlight \n Guitar");
            int time = 60;

            string[] items = new string[12];
            int slots = 4;
            while (time>1)
            {
                Console.WriteLine("Chose an item :");
                string holder = Console.ReadLine();
                if (holder=="Water bottle 10L")
                {
                    slots = slots - 4;
                }

            }
            



       
        }
    }
}
