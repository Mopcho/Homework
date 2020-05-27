using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Classes : IClasses
    {
        private readonly IEnumerable<Teacher> _teachers;

        public IEnumerable<Teacher> Teachers { get { return _teachers; } }

        public Classes(IEnumerable<Teacher> teachers)
        {
            this._teachers = teachers;
        }
    }
}
