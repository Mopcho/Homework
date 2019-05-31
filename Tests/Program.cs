using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Person
    {
        private int Age;
        private string Name;
        public int age { set { this.Age = value; } }
        public string name { set { this.Name = value; } }
    }
    class Policeman
    {
        private int CardNumber;
        private string Name;
        public Policeman(int cardNumber,string name)
        {
            this.CardNumber = cardNumber;
            this.Name = name;
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person numb1 = new Person();
            numb1.age = 18;
            numb1.name = "Mariika";
            Policeman Police = new Policeman(18445,"Pesho");
          
        }
    }
}
