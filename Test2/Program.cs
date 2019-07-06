using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
 public interface IAnimal
    {
         int Age { get; set; }
        string Name { get; set; }
        string Type { get; set; }

        
    }
    class Dog : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            

        }
        
    }
}
