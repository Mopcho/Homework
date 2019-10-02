using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public static Point3D Center { get { return _center;  }  }
        private static readonly Point3D _center  = new Point3D(0, 0, 0);
        public Point3D(int x,int y,int z)        
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override string ToString()
        {
            
            return string.Format("{0} {1} {2}",this.X,this.Y,this.Z);
        }
        
    }
}
