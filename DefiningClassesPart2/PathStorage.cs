using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefiningClassesPart2
{
    public static class PathStorage
    {
        public static void Save(List<Point3D> pointSeq)
        {
            string a = "";
           for (int i=0;i<pointSeq.Count;i++)
            {
                a += pointSeq[i].ToString();
                
            }
            File.WriteAllText("C:\\Users\\PC\\Desktop\\PathStorage.txt",a);
        }
        public static void Load()
        {
            
        }
    }
}
