using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3HW.Extensions
{
    public static class AverageExtension
    {
        public static T Average<T> (this IEnumerable<T> enumeration)
        {
            dynamic average = 0;
            foreach (var n in enumeration)
            {
                average += n;
            }
            average = average / 2;
            return average;
        }
    }
}
