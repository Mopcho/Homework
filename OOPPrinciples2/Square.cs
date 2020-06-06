using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    public class Square : Shape, IShape
    {
        public Square(double size) : base(size,size)
        {
            
        }

        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
