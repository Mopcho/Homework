using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Dogs
{
    public class Dog
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Food { get; set; } = 10;
        public int Water { get; set; } = 10;
        public Dog(int age,string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
