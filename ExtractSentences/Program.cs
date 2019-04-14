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
            int wordLeng = word.Length;
            string holder = "";
            int checkpoint = 0;
            int sentances = 0;
          
            for (int i=0;i<input.Length;i++)
            {
                if (input[i]=='.')
                {
                    sentances++;
                }
            }
            int[] Arr = new int[sentances];
            int[] ArrPoints = new int[sentances];
            int countChars = 0;
            int u = 0;
            string checker = "";
            for (int i = 0; i < sentances; i++)
            {
                while (true)
                {
                    
                    if (input[u]=='.')
                    {
                        ArrPoints[i] = u;
                        break;
                    }
                    u++;
                    countChars++;
                }
                Arr[i] = countChars;
                countChars = 0;
            }
                for (int i=0;i<sentances;i++)
                {
                    for (int a=0;a<Arr[i];a++)
                    {
                        for (int c=0;c<word.Length;c++)
                        {

                        }
                        if (checker==word)
                        {

                        }
                    }
                    for (int b=0;b<Arr[i];b++)
                    {

                    }
                }
        }
    }
}
