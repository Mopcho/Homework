using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes1
{
    public class Display
    {
        public int Size { get { return _size; } set { _size = value; } }
        public int NumberOfColors { get { return _numberOfColors; } set { _numberOfColors = value; } }
        private int _size;
        private int _numberOfColors;
        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
    }
}
