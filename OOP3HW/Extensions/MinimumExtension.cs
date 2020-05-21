using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3HW.Extensions
{
    public static class MinimumExtension
    {
        public static T Mmin<T>(this IEnumerable<T> enumeration)
            where T : IConvertible , IComparable
        {
            dynamic min = enumeration.First();
            foreach (var n in enumeration) 
            {
                if (n.CompareTo(min)<0)
                {
                    min = n;
                }
            }
            return min;
        }
    }
}
