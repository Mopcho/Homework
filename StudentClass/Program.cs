using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClass.Enums;

namespace StudentClass
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Gosho","Patkan","Siliminski","Sliven","08967745","Gosho@abv.bg","C#",SpecialityType.CSharpDev,UniversityType.Softuni,FacultyType.Three);
            Student student2 = new Student("Gosho","Patkan", "Siliminski", "Sliven", "08967745", "Gosho@abv.bg", "C#", SpecialityType.CSharpDev, UniversityType.Softuni, FacultyType.Three);
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine(student1==student2);


            // Student copy = (Student)student1.Clone();
            //
            // Console.WriteLine(student1);
            // Console.WriteLine(copy);
            //
            // copy.FirstName = "asdasd";
            //
            // Console.WriteLine(student1);
            // Console.WriteLine(copy);

            Console.WriteLine(student1.CompareTo(student2));
        }
    }
}
