using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
   public class Path
    {
        public List<Point3D> PointSeq { get; set; }
        public void Add(Point3D point)
        {
            Point3D newPoint = point;
            PointSeq.Add(newPoint);
        }
    }
}
