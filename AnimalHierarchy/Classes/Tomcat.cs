using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Interfaces;

namespace AnimalHierarchy.Classes
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat(int age, string name, string sex) : base(age, name, sex)
        {
            if (sex != "Male")
            {
                throw new Exception("Tomcats can only be male");
            }
        }
    }
}
