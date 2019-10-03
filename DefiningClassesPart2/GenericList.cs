using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public class GenericList<T>
    {
        private int _capacity;
        private int _index;
        public T[] List { get; set; }
        public GenericList(int capacity)
        {
            this._capacity = capacity;
            this.List = new T[capacity];
        }
        public void Add(T element)
        {
            this.List[this._index] = element;
            this._index++;
        }
        public void PrintElement(int index)
        {
            Console.WriteLine(this.List[index]);
        }
        public void Delete(int index)
        {
            T[] newList = new T[this._capacity];
            for (int i=0;i<this._capacity;i++)
            {
                if (i != index)
                {
                    newList[i] = this.List[i];
                }
                
            }
            this.List = newList;
        }
        public void InsertAt(int index,T element)
        {
           
            this.List[index] = element;
        }
        public void ClearAll()
        {
           T[] newList=new T[this._capacity];
            this.List = newList;
        }
        public int FindByValue(T element)
        {
            for (int i=0;i<_index;i++)
            {
                if (element.Equals(this.List[i]))
                {
                    return i;
                }
               
            }
            return -1;
        }

    }
}
