using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Interfaces
{
    interface IDiscipline
    {
        string Name { get; }

        int NumberOfExcercises { get; }

        int NumberOfLectures { get; }
    }
}
