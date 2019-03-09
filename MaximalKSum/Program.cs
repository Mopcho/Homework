using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] ArrN = new int[n];
            int[] ArrK = new int[k];
            int bigger = -100;
            int counter = 1;
            int fakeA = 0;
            for (int i = 0; i < n; i++)
            {
                ArrN[i] = int.Parse(Console.ReadLine());
            }
          
            for (int i=0;i<k;i++)
            {
                for (int a = 0; a < n; a++)
                {
                   
                    if (ArrN[a]>bigger)
                    {
                        
                        bigger = ArrN[a];


                        fakeA = a;
                    }
                   
                }
                
                ArrN[fakeA] = -1000;
              
                ArrK[i] = bigger;
                bigger = -100;
            }
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum = sum + ArrK[i];  
            }
            Console.WriteLine(sum);
        }
    }
}
