using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Interfaces;

namespace AnimalHierarchy.Classes
{
    public class Kitten : Cat, ISound
    {
        public Kitten(int age, string name, string sex) : base(age, name, sex)
        {
            if(sex != "Female")
            {
                throw new Exception("Kittens can only be Female");
            }
        }
    }
}
