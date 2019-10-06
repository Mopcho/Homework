using System;
using System.Diagnostics;
using System.Linq;
using System.Timers;

namespace CowMusic
{
    class Program
    {
        private static bool lever;

        static void Main(string[] args)
        {
            var timer = new Timer(1000);
            timer.AutoReset = true;

            timer.Elapsed += EventHandler;

            timer.Start();

            Console.ReadLine();
        }

        private static void EventHandler(object sender, ElapsedEventArgs e)
        {

            
            int minute = DateTime.Now.Minute;
          
            int[] desiredMinutes = { 18, 20 };

            for (int i = 0; i < desiredMinutes.Length; i++)
            {
                int desiredMinute = desiredMinutes[i];

                if (desiredMinute == minute && !lever)
                {
                    lever = true;

                    string urlForThePlayList =
                        "https://www.youtube.com/watch?v=foE1mO2yM04&list=PLwLeqKCWCxyTQWisBC4oWfV77UaJ6WPdN&index=1";

                    Process.Start(urlForThePlayList);
                }
                else if(lever && minute==desiredMinute+1)
                {
                    lever = false;
                    
                }
            }
        }
    }
}