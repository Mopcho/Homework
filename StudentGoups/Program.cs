using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGoups
{
    public delegate IEnumerable<Student> Predicate(IEnumerable<Student> students);
    static class Program
    {
        public static void PrintAll(IEnumerable<Student> students,Predicate predicate)
        {
            Console.WriteLine("==============");
            var sortedStudents = predicate(students);
            foreach (var n in sortedStudents)
            {
                Console.WriteLine(n.FirstName + "\r\n" + n.LastName + "\r\n" + n.FN + "\r\n" + n.Tel + "\r\n" + n.Email + "\r\n" + n.GroupNumber + "\r\n ==========");
            }
        }

        public static IOrderedEnumerable<Student> FromGroup(IEnumerable<Student> students)
        {
            var studentsFromSecGrp = from student in students
                                     where student.GroupNumber == 2
                                     orderby student.FirstName
                                     select student;
            return studentsFromSecGrp;
        }

        public static IEnumerable<Student> WithAbv(IEnumerable<Student> students)
        {
            var studentsWithAbv = from student in students
                                  where student.Email.Contains("abv.bg")
                                  select student;
            return studentsWithAbv;
        }

        public static IEnumerable<Student> SofiaNumber (IEnumerable<Student> students)
        {
            var studentsWithSofiaPhone = from student in students
                                         where student.Tel.Contains("087")
                                         select student;
            return studentsWithSofiaPhone;
        }

        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Georgi" , "Komshiiski","Fakultet : 10","08712323","Petko@sonat.bg",new List<string>() {"M : 5","AE : 6,NE : 2"},2 ),
                new Student("Patkan" , "Bogomilski","Fakultet : 11","08925623","Patkata@abv.bg",new List<string>() {"M : 2","AE : 2","NE : 2"},1 ),
                new Student("Grigor" , "Dimitrov","Fakultet : 10","08724623","Grisho@keral.bg",new List<string>() {"M : 2","AE : 4","NE : 3"},6 ),
                new Student("Stoyan" , "Murgavski","Fakultet : 12","08593323","Tqnata@gmail.bg",new List<string>() {"M : 6","AE : 6","NE : 6"},2 ),
                new Student("Frau" , "Koicheva","Fakultet : 10","08912693","Nadejdata@abv.bg",new List<string>() {"M : 4","AE : 5","NE : 3"},3 )
            };
           
            PrintAll(students, FromGroup);

            PrintAll(students, WithAbv);
            
            PrintAll(students,SofiaNumber);

        }
    }
}
