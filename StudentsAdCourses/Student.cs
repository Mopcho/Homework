using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAdCourses
{
    public class Student
    {
        private string name;

        private int uniqueNumber;

        private Course course;

        public Course Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }

        public int UniqueNumber {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (value >= 10000 && value <= 99999)
                {
                    this.uniqueNumber = value;
                }
                else
                {
                    throw new Exception("Number should be between 10 000 and 99 9999");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Name can not be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public void GoToClass()
        {
            this.course.AddStudentToClass(this);
        }

        public Student(string name, int uniqueNumber,Course course)
        {
            this.Course = course;
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public void LeaveClass()
        {

        }

    }
}
