using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Interfaces;

namespace School
{
    public class Teacher : People , ITeacher
    {
        private Disciplines[] _disciplines;

        public Disciplines[] Disciplines { get { return _disciplines; } }

        public Teacher(string name,Disciplines[] disciplines ) : base(name)
        {
            this._disciplines = disciplines;
        }
    }
}
