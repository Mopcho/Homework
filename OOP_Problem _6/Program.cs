using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Problem__6
{
    class Program
    {   
        public static void PrintAll<T>(IEnumerable<T> enumerable)
        {
            foreach (var n in enumerable)
            {
                Console.Write($"  {n}");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            var numbers = new int[] { 1, 3, 5, 7, 21, 34, 42, 49, 90 ,105,134,168};

            var divisibleByThreeAndSeven = numbers
                .Where(x => x % 3 == 0 && x % 7 == 0);

            PrintAll(divisibleByThreeAndSeven);

            var divisibleByThreeAndSevenLINQ = from n in numbers
                                               where n % 3 == 0 && n % 7 == 0
                                               select n;

            PrintAll(divisibleByThreeAndSevenLINQ);
        }
    }
}
