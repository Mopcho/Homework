using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schooll
{
    public class Course
    {
        private List<Student> students;

        private int idOfClass;

        private int maxStudents;

        public int MaxStudents
        {
            get
            {
                return this.maxStudents;
            }
            set
            {
                this.maxStudents = value;
            }
        }

        public int IDOfClass
        {
            get
            {
                return this.idOfClass;
            }
            set
            {
                if (value > 1000000)
                {
                    throw new Exception("ID cant be more than 1000000");
                }
                else
                {
                    this.idOfClass = value;
                }

            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public Course(int id, int maxStudents)
        {
            this.students = new List<Student>()
            {
                new Student("Lecturer",11111,this)
            };
            this.maxStudents = maxStudents;
            this.IDOfClass = id;
        }
        public void AddStudentToClass(List<Student> students)
        {
            foreach (var student in students)
            {
                this.students.Add(student);

                if (this.students.Count > this.maxStudents)
                {
                    throw new Exception("Students in this room cant be more than 30");
                }
            }

            Console.WriteLine($"Students in this class : {this.students.Count}");
        }
        public void AddStudentToClass(Student student)
        {
            if (this.students.Count > this.maxStudents)
            {
                throw new Exception("Students in this room cant be more than 30");
            }

            this.students.Add(student);

            Console.WriteLine($"Students in this class : {this.students.Count}");
        }
        public void RemoveStudent(int uniqueNumberOfStudent)
        {
            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].UniqueNumber == uniqueNumberOfStudent)
                {
                    Console.WriteLine($"Student {students[i].Name} with Unique Number : {students[i].UniqueNumber} has left");
                    students.RemoveAt(i);
                }
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            foreach (var student in this.students)
            {
                str.AppendLine($"{student.Name} : {student.UniqueNumber}");
            }

            return str.ToString();
        }
    }
}
