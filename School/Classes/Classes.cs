using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Interfaces;

namespace School
{
    public class Classes : IClasses, IComment
    {
        private readonly IEnumerable<Teacher> _teachers;

        public IEnumerable<Teacher> Teachers { get { return _teachers; } }

        public Classes(IEnumerable<Teacher> teachers)
        {
            this._teachers = teachers;
        }

        public void Comment(string comment)
        {
            Console.WriteLine(comment);
        }
    }
}
