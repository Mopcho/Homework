using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Classes;

namespace StudentsAndWorkers.Interfaces
{
    public abstract class Human
    {
        private string _firstName;

        private string _lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this._firstName;}
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cant be null or empty");
                }
                _firstName = value;
            }
        }

        public string LastName { get {return this._lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cant be null or empty");
                }
                _lastName = value;
            }
        }

    }
}
