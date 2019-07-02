using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Dog
    {
        public int Legs { get; set; }
        public Dog(int legs)
        {
            this.Legs = legs;
        }
    }
    struct Cat
    {
        public int Legs { get; set; }
        public Cat(int legs)
        {
            this.Legs = legs;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(10);
            Cat cat = new Cat(5);
            ChangeSmth(cat);
            ChangeSmth1(dog);
            Console.WriteLine("{0} {1}",cat.Legs,dog.Legs);
            Dog sameDog = dog;
            sameDog.Legs = 11;
            Console.WriteLine(dog.Legs);
        }
        public static void ChangeSmth(Cat cat)
        {
            cat.Legs = 6;
        }
        public static void ChangeSmth1(Dog dog)
        {
            dog.Legs = 7;
        }
    }
}
