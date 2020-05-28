using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Classes;
using AnimalHierarchy.Interfaces;
namespace AnimalHierarchy
{
    class Program
    {
        static void Main()
        {

            Animal[] animals = new Animal[]
            {
                new Cat(11,"Stoyan","Female"),
                new Dog(14,"Mopcho","Male"),
                new Frog(67,"Froggie","Female"),
                new Kitten(2,"Kittie","Female"),
                new Tomcat(2,"Tommy","Male")
            };

            var dogs = animals.Where(x=>x is Dog);
            var cats = animals.Where(x => x is Cat);
            var frogs = animals.Where(x => x is Frog);

            Console.WriteLine(Animal.AverageAge(animals));

            Console.WriteLine(Animal.AverageAge(dogs));
            Console.WriteLine(Animal.AverageAge(cats));
            Console.WriteLine(Animal.AverageAge(frogs));
        }
    }
}
