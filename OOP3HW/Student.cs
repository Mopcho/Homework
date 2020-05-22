using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3HW
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public static void Print(Student[] students)
        {
            foreach (var n in students)
            {
                Console.WriteLine($"{n.Name}  :  {n.Age}");
            }
        }
    }
}
