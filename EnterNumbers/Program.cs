using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string holder = "1<";
            int[] Arr = new int[10];
            Arr[0] = 1;
            for (int i=1;i<Arr.Length;i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
                if (Arr[i]<Arr[i-1] || Arr[i]>=100)
                {
                    throw new Exception("Exception");
                }
                holder += Arr[i].ToString()+"<";
            }
            holder +="100";
            Console.WriteLine(holder);
          
        }
    }
}
