using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Interfaces
{
    public interface IAnimal
    {
        int Age { get; }
        string Name { get; }
        string Sex { get; }

    }
}
