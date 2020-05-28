using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Interfaces;

namespace AnimalHierarchy.Classes
{
    public class Dog :Animal,  ISound
    {
        public Dog(int age, string name, string sex) : base(age, name, sex)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Bark bark");
        }
       
    }
}
