using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    public class Triangle : Shape
    {
        public override double CalculateSurface()
        {
            return this.height * this.width / 2;
        }
    }
}
