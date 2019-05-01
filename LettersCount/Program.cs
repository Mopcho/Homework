using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string holder = "";
            bool lever = true;
            List<char> list = new List<char>();
            for (int i=0;i<text.Length;i++)
            {
                for (int a=0;a<i;a++)
                {
                    if (list[a]==text[i])
                    {
                        lever = false;
                        break;
                    }
                }
                if (lever==true)
                {
                    list.Add(text[i]); 
                }
            }
            char[] Arr = new char[list.Count];
            for (int i=0;i<Arr.Length;i++)
            {
                Arr[i] = list[i];
            }
            int[] ArrNums = new int[Arr.Length];
            int counter = 0;
            char[] charArr = new char[Arr.Length];
           
         
            for (int i=0;i<Arr.Length;i++)
            {
                for (int a=0;a<text.Length;a++)
                {
                    if (Arr[i]==text[a])
                    {
                        counter++;
                    }
                  
                }
                ArrNums[i] = counter;
                counter = 0;
            }
            for (int i=0;i<Arr.Length;i++)
            {
                Console.WriteLine("{0} {1}", Arr[i], ArrNums[i]);
            }
        }
    }
}
