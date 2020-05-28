using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Interfaces;

namespace School
{
    public class Student : People , IStudent 
    {
        private readonly int _classNumber;

        public int ClassNumber { get { return this._classNumber; } }

        public Student(string name, int classNumber) : base(name)
        {
            this._classNumber = classNumber;
        }
    }
}
