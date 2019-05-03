using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numStr = number.ToString();
            int sum = 0;
            if (numStr[2]=='0')
            {
                sum = int.Parse(numStr[0].ToString()) + int.Parse(numStr[1].ToString());
            }
            else if (int.Parse(numStr[2].ToString())<5)
            {
                sum = (int.Parse(numStr[0].ToString()) + int.Parse(numStr[1].ToString()))/int.Parse(numStr[2].ToString());
            }
            else if (int.Parse(numStr[2].ToString()) > 5)
            {
                sum = (int.Parse(numStr[0].ToString()) + int.Parse(numStr[1].ToString())) * int.Parse(numStr[2].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
