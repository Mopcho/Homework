using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    public class Rectangle : Shape , IShape
    {
        public Rectangle(double width,double height) : base(width,height)
        {

        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
