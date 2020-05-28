using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main()
        {
            var student = new Student("Pesho", 11);
            Console.WriteLine(student.Name);
            Disciplines[] disciplines = new Disciplines[]
            {
                new Disciplines("Math", 12, 3),
                new Disciplines("English" , 13 , 5)
            };
            var teacher = new Teacher("Koicheva", disciplines);
            teacher.Comment("asdas");
            Console.WriteLine(teacher.Name);
            for (int i=0;i<teacher.Disciplines.Count();i++)
            {
                Console.WriteLine(teacher.Disciplines[i].Name);
                Console.WriteLine(teacher.Disciplines[i].NumberOfExcercises);
                Console.WriteLine(teacher.Disciplines[i].NumberOfLectures);
            }
        }
    }
}
