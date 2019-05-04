using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            try
            {
                if (number < 0)
                {
                    throw new Exception();
                }
                double root = Math.Sqrt(number);
                Console.WriteLine(root);
              
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Invalid Number!");
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }
            
        }
    }
}
