using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3HW
{
    public static class IEnumerableExtensions
    {
      public static T Msum<T>(this IEnumerable<T> enumerable)
      {
            dynamic sum = 0;
            foreach (var n in enumerable)
            {
                sum += n;
            }
            return sum;
      }

    }
}
