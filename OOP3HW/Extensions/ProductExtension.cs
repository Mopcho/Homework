using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3HW.Extensions
{
    public static class ProductExtension
    {
        public static T Product<T>(this IEnumerable<T> enumerable)
        {
           dynamic product = 1;
           foreach (var n in enumerable)
            {
                product *= n;
            }
            return product;
        }
    }
}
