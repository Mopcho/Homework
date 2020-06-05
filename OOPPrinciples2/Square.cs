using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    public class Square : Shape
    {
        public Square(double size)
        {
            this.width = size;
            this.height = size;
        }

        public override double CalculateSurface()
        {
            return height * width;
        }
    }
}
