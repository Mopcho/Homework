using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;

        private byte age;

        public Person(string name,byte age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (name==null)
                {
                    throw new NullReferenceException();
                }
                this.name = value;
            }
        }

        public byte? Age { get; set; }
       

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Name : {this.Name}");

            str.AppendLine("Age: " + (this.Age.HasValue ? this.Age.ToString() : "not specified"));

            return str.ToString();
        }
    }
}
