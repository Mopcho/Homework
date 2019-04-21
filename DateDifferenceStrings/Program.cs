using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifferenceStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date =DateTime.Parse(Console.ReadLine());
            DateTime dateTwo = DateTime.Parse(Console.ReadLine());
            double dateThree = (date - dateTwo).TotalDays;

        }
    }
}
