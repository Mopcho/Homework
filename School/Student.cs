using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : IPeople , IStudent
    {
        private readonly string _name;

        private readonly int _classNumber;

        public int ClassNumber { get { return this._classNumber; } }

        public string Name { get { return this._name; }  }

        public Student(string name, int classNumber)
        {
            this._name = name;
            this._classNumber = classNumber;
        }
    }
}
