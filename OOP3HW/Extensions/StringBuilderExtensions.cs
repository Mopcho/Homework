using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3HW
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int index, int length)
        {
            return new StringBuilder(strBuilder.ToString().Substring(index, length));
        }
    }
}
