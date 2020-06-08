using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClass.Enums;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace StudentClass
{
    [Serializable]
    public class Student : IStudent , ICloneable , IComparable<Student>
    {
        //fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private string course;
        private SpecialityType speciality;
        private UniversityType university;
        private FacultyType faculty;
        //constructor
        public Student(string firstName, string middleName, string lastName, string permanentAddress, string mobilePhone, string email, string course, SpecialityType speciality, UniversityType university, FacultyType faculty)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            PermanentAddress = permanentAddress;
            MobilePhone = mobilePhone;
            Email = email;
            Course = course;
            Speciality = speciality;
            University = university;
            Faculty = faculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length > 10)
                {
                    throw new Exception("Name cant be more than 10 symbols");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                if (value.Length > 10)
                {
                    throw new Exception("Name cant be more than 10 symbols");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length > 10)
                {
                    throw new Exception("Name cant be more than 10 symbols");
                }
                this.lastName = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            private set
            {
                if (value.Length > 10)
                {
                    throw new Exception("Address cant be more than 10 symbols");
                }
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            private set
            {
                if (value.Length > 11)
                {
                    throw new Exception("Mobile number cant be more than 10 symbols");
                }
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                if (value.Length > 20)
                {
                    throw new Exception("Email cant be more than 10 symbols");
                }
                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                if (value.Length > 10)
                {
                    throw new Exception("Course cant be more than 10 symbols");
                }
                this.course = value;
            }
        }

        public SpecialityType Speciality
        {
            get
            {
                return this.speciality;
            }
            private set
            {
                this.speciality = value;
            }
        }

        public UniversityType University
        {
            get
            {
                return this.university;
            }
            private set
            {
                this.university = value;
            }
        }

        public FacultyType Faculty
        {
            get
            {
                return this.faculty;
            }
            private set
            {
                this.faculty = value;
            }
        }

        public override bool Equals(object param)
        {
            Student other = param as Student;
            //Use this for content check
             if (this.firstName == other.firstName && this.middleName == other.middleName && this.lastName == other.lastName && this.permanentAddress == other.permanentAddress
                 && this.mobilePhone == other.mobilePhone && this.email == other.email && this.course == other.course && this.speciality == other.speciality &&
                 this.university == other.university && this.faculty == other.faculty) 
                 return true;
             //use this for reference check
           // if (Object.Equals(this.firstName, other.firstName) && Object.Equals(this.middleName, other.middleName)
           //      && Object.Equals(this.lastName, other.lastName) && Object.Equals(this.permanentAddress, other.permanentAddress)
           //      && Object.Equals(this.mobilePhone, other.mobilePhone) && Object.Equals(this.email, other.email)
           //      && Object.Equals(this.course, other.course) && Object.Equals(this.speciality, other.speciality)
           //      && Object.Equals(this.university, other.university) && Object.Equals(this.faculty, other.faculty))
           //     return true;
            return false;
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }

        public object Clone()
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Position = 0;
                return formatter.Deserialize(stream);
            };
        }
        
        public int CompareTo(Student other)
        {
            if (this.Equals(other))
                return 0;

            var firstStudent = new Student[] { this, other }.OrderBy(student => student.FirstName)
                                                            .ThenBy(student => student.MiddleName)
                                                            .ThenBy(student => student.LastName)
                                                            .ThenBy(student => student.MobilePhone)
                                                            .First();

            return this.Equals(firstStudent) ? -1 : 1;
        }

        public static bool operator  == (Student student1 , Student student2) 
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator != (Student student1 , Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"First Name : {this.firstName}");
            str.AppendLine($"Second Name : {this.middleName}");
            str.AppendLine($"Last Name : {this.lastName}");
            str.AppendLine($"Permanent Address : {this.permanentAddress}");
            str.AppendLine($"Mobile phone : {this.mobilePhone}");
            str.AppendLine($"Email : {this.email}");
            str.AppendLine($"Course : {this.course}");
            str.AppendLine($"Speciality : {this.speciality}");
            str.AppendLine($"University : {this.university}");
            str.AppendLine($"Faculty : {this.faculty}");

            return str.ToString();
        }
    }
}
