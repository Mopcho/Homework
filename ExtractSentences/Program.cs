using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = Console.ReadLine();
            string holder = "";
            string[] arr = input.Split('.');
            for (int i=0;i<arr.Length;i++)
            {
                string current = arr[i];
                string[] currentArr = current.Split(' ');
                for (int j = 0; j < currentArr.Length; j++)
                {
                    string currentWord = currentArr[j];
                    if (currentWord == word)
                    {
                        holder += current + ".";
                    }
                }

            }
            Console.WriteLine(holder);
       
         
        }
    }
}
