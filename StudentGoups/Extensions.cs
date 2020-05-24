using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGoups
{
   public static class Extensions
    {
         public static IEnumerable<Student> ExtractWithTwoMarks(this List<Student> students)
         {
            var sortedStuds = from student in students
                              where student.Marks.Count < 3
                              select student;
            return sortedStuds;
         }
    }
}
