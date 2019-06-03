using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Person 
    {
        private const int Age=10;
        public readonly string Name;
        public string vtoroIme { get; set; }
        public Person(int age, string name) :this("Pesho")
        {
            Console.WriteLine(this.Name);
            this.Name = name;
        }
        public Person(string name)
        {
            this.Name = name;
        }


    }
   
    class Program
    {
        static void Main(string[] args)
        {
            
            
         

        }
    }
}
