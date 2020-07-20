using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAdCourses
{
    class Program
    {
        static void Main()
        {
            string name = "Student 1";
            int numb = 99999;
            Course englishCourse = new Course(1000,4);
            Student student = new Student(name, numb,englishCourse);
            student.GoToClass();
            List<Student> students = new List<Student>()
            {
                new Student("Pesho",10000,englishCourse),
                new Student("Ivan",10001,englishCourse),
            };
            englishCourse.AddStudentToClass(students);
            englishCourse.RemoveStudent(10001);
            Console.WriteLine(englishCourse);
        }
    }
}
