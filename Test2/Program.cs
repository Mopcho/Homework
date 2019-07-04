using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class GenericList<T>
    {
        public T[] Data { get; set; }
        public int Index { get; set; } 
        public int Limit { get; set; }
        public GenericList(int index,int limit)
        {
           this.Data= new T[index];
            this.Limit = limit;
        }
        public void Add(T data)
        {
            if(this.Index==Limit-1)
            {
                Limit = Limit * 2;

            }
            this.Data[this.Index++] = data;
        }
        

    }

    

    

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

        }
        
    }
}
