using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Person
    {
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        protected int _age;
        public void SetAge(int age)
        {
            this._age = age;
        }
    }
    class Studen : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is {0}",_age);
        }
        public void GoToClassess()
        {
         
            Console.WriteLine("Going to class");
        }
    }
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explaining");
        }
    }
    class Program
    {
        class StudentAndTeacherTest
        {
            static void Main(string[] args)
            {
                var myPerson = new Person();
                myPerson.Greet();
                var myStudent = new Studen();
                myStudent.SetAge(21);
                myStudent.Greet();
                myStudent.ShowAge();
                var myTeacher = new Teacher();
                myTeacher.Greet();
                myTeacher.Explain();
            }
        }
    }
}
