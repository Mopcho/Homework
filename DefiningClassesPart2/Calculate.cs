using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public static   class Calculate
    {
        public static  Point3D CalculatePoint(Point3D pointOne,Point3D pointTwo)
        {
            int x = pointOne.X - pointTwo.X;
            int y = pointOne.Y - pointTwo.Y;
            int z = pointOne.Z - pointTwo.Z;
            Point3D custom = new Point3D(z,y,z);
            return custom;
        }
    }
}
