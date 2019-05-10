using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();
            int diff = 0;
            int same = 0;
            string holder1 = "";
            string holder2 = "";
            using (StreamReader sr=new StreamReader(file1))
            {
                holder1 += sr.ReadToEnd();
            }
            using (StreamReader sr1=new StreamReader(file2))
            {
                holder2 += sr1.ReadToEnd();
            }
            string[] arr1 = holder1.Split('\n');
            string[] arr2 = holder2.Split('\n');
            for (int i=0;i<arr1.Length-1;i++)
            {
                if (arr1[i] == arr2[i])
                {
                    same++;
                }
                else
                {
                    diff++;
                }
            }
            Console.WriteLine("Same : {0}  Different : {1}", same, diff);
        }
    }
}
