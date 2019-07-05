using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
   class Animal
    {
         public  int Age { get; set; }
    }
   class Dog : Animal
    {
      

    }
    class GenericList<T> where T : Animal
    {
        public string Animal {get;set;}

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            

        }
        
    }
}
