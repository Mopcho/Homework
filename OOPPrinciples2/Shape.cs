using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    public abstract class Shape : IShape
    {
        private double width;

        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Value cant be smaller than 0");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Value cant be smaller than 0");
                }
                this.height = value;
            }
        }
        public abstract double CalculateSurface();
    }
}
