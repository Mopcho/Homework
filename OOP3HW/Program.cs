using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP3HW.Extensions;

namespace OOP3HW
{
    class Program
    {
        public static string[] ByAge(Student[] students)
        {
            string[] sortedStudents = students
            .Where(student => student.Age >= 18 && student.Age <= 24)
            .Select(student => student.Name).ToArray();

            return sortedStudents;
        }
       
        public static Student[] OrderByName(Student[] students)
        {
          students = students.OrderBy(student => student.Name.Split(' ')[0]) 
                             .ThenBy(student => student.Name.Split(' ')[1]).Reverse().ToArray();
            return students;
        }
        //bugged 2riq orderby overrideva purviq
        public static Student[] OrderByNameLINQ(Student[] students)
        {
            var studentArr = from n in students
                             orderby n.Name.Split(' ')[0]
                             orderby n.Name.Split(' ')[1] 
                             select n;
                                  

            return studentArr.ToArray();
        }

        static void Main()
        {
            var students = new Student[]
            {
                new Student("aaaa bbbb", 18),
                new Student("aaaa aaaa",25),
                new Student("bbbb bbbb",19),
                new Student("bbbb aaaa",24),
                new Student("zzzz zzzz",17),
                new Student("gggg gggg",13),
                new Student("ssss ssss",14)
            };
            //Sorts by Age 
            string[] sortedStudents = ByAge(students);
            for (int i = 0; i < sortedStudents.Length; i++)
            {
                Console.WriteLine(sortedStudents[i]);
            }
            //Sorts by First name and then by second name in descending order
            Student.Print(OrderByName(students));
            Student.Print(OrderByNameLINQ(students));
        }
    }
}
