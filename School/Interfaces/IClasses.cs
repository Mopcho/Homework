using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public interface IClasses
    {
       IEnumerable<Teacher> Teachers { get; }
    }
}
