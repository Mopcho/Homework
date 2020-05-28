using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Interfaces;

namespace StudentsAndWorkers.Classes
{
    public class Student : Human, IStudent
    {
        private int _grade;

        public Student(string firstName, string lastName,int grade) : base(firstName,lastName)
        {
            this.Grade = grade;
        }
        public int Grade { get { return this._grade; }
            private set
            {
                if (value > 12|| value<1)
                {
                    throw new Exception("Grade must be from 1 to 6");
                }
                this._grade = value;
            }
        }
    }
}
