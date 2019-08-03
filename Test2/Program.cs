using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.Folder1;
using Test2.Dogs;

namespace Test2
{
 
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What animal do you want to buy?");
            string answer = Console.ReadLine();
            if (answer == "Cat")
            {
                Cat cat = new Cat();
            }
            else if (answer == "Dog")
            {
                Console.WriteLine("Chose a name and an age of the dog");
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Dog dog = new Dog(age, name);
            }
            while (true)
            {

            }
        }
        
    }
}
