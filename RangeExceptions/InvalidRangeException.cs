using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private const string ErrorMessage = "ERROR: The value is not in range";

        public InvalidRangeException(string message = ErrorMessage, Exception innerEx = null) : base(message, innerEx)
        {
        }

        public InvalidRangeException(T begin, T last, string message = ErrorMessage, Exception innerEx = null) : base(message, innerEx)
        {
            this.Begin = begin;
            this.Last = last;
        }

        public T Begin { get; private set; }

        public T Last { get; private set; }
    }
}
