using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalAreaSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();
            string number;
            Random rd = new Random();
            string randomNum="";
            int sum = 0;
            using (StreamReader sr = new StreamReader(file1))
            {
               number = sr.ReadLine();
            }
            using (StreamWriter sw=new StreamWriter(file1))
            {
                sw.WriteLine(number);
                for (int i=0;i<int.Parse(number);i++)
                {
                    for (int a=0;a<int.Parse(number);a++)
                    {
                        randomNum = rd.Next(1, 10).ToString();
                        sum += int.Parse(randomNum);
                        sw.Write(" "+randomNum);
                    }
                    sw.WriteLine();
                }
            }
            using (StreamWriter sw1=new StreamWriter(file2))
            {
                sw1.Write(sum);
            }

        }
    }
}
