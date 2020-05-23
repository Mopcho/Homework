using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGoups
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<string> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, string fN, string tel, string email, List<string> marks, int groupNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            FN = fN;
            Tel = tel;
            Email = email;
            Marks = marks;
            GroupNumber = groupNumber;
        }

       
    }
}
