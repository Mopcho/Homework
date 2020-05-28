using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Interfaces;

namespace School
{
    public class People : IPeople, IComment
    {
        private string _name;

        public string Name { get { return _name; } }

        public People(string name)
        {
            this._name = name;
        }

        public void Comment(string comment)
        {
            Console.WriteLine(comment);
        }
    }
}
