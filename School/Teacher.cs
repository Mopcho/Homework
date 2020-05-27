using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : IPeople
    {
        private readonly string _name;

        public string Name { get { return this._name; } }

        public Teacher(string name)
        {
            this._name = name;
        }
    }
}
