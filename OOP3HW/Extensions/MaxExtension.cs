using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3HW.Extensions
{
    public static class MaxExtension
    {
        public static T Max<T>(this IEnumerable<T> enumeration)
            where T : IComparable, IConvertible
        {
            dynamic max = enumeration.First();
            foreach (var n in enumeration)
            {
                if (n.CompareTo(max)>0)
                {
                    max = n;
                }
            }
            return max;
        }
    }
}
