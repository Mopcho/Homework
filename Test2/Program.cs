using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class GenericList<T>
    {
        
        private int counter=0;
        public int Index { get; set; } = 0;
        public GenericList(int scale)
        {
          T[] Data = new T[scale];
        }
        public void Add(T info)
        {
           this.Data[counter++] = info;
        }
        
    }
}
    
    

    
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
            var GL = new GenericList();

        }
        
    }
}
