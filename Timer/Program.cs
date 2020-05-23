using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Timer
{
    public delegate void Predicate(int time);
    class Timer
    {
        public static void RepeatOn(int time,Predicate predicate)
        {
            while (true)
            {
                predicate(time);
            }
        }
        public static void Hour(int time)
        {
            Thread.Sleep(time * 1000 * 60 * 60);
            Console.WriteLine($"{time} seconds passed");
        }
        public static void Minutes(int time)
        {
            Thread.Sleep(time * 1000 * 60);
            Console.WriteLine($"{time} seconds passed");
        }
        public static void Seconds(int time)
        {
                Thread.Sleep(time * 1000);
                Console.WriteLine($"{time} seconds passed");
        }
        public static void Miliseconds(int time)
        {
                Thread.Sleep(time);
                Console.WriteLine($"{time} Miliseconds passed");
        }
        static void Main()
        {
          RepeatOn(1,Hour);
        }
    }
}
