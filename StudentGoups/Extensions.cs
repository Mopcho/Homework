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
        public static Student[] GroupStud (this IEnumerable<Student> students,int group) 
        {
        var grouped = students
               .Where(x => x.GroupNumber == group).ToArray();
        return grouped;
        }
    }
}
