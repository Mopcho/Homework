using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Interfaces;

namespace AnimalHierarchy.Classes
{
   public class Animal : IAnimal, ISound
    {
        private int _age;

        private string _name;

        private string _sex;

        protected Animal(int age,string name,string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            private set
            {
                if (value > 200 || value<0)
                {
                    throw new Exception("Age cant be more than 200 years or less than 0");
                }
                this._age = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            private set
            {
                if (value.Length > 15)
                {
                    throw new Exception("There are no names with more than 15 symbols !");
                }
                this._name = value;
            }
        }

        public string Sex
        {
            get
            {
                return this._sex;
            }
            private set
            {
                if(value == "Male" || value == "Female")
                {
                    this._sex = value;
                }
                else
                {
                    throw new Exception("Sex can be either  'Male' or 'Female' ");
                }
            }
        }
        public void Sound()
        {
            throw new Exception("Bruh be specific");
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            int[] animalAges = animals
                .Select(x=>x.Age).ToArray();
            int sum = 0;
            for (int i=0;i<animalAges.Length;i++)
            {
                sum += animalAges[i];
            }
            double averageAge = sum / animalAges.Length;
            return averageAge;
        }
    }
}
