using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeAndDecode
{
    class Program
    {
        public static string Encode(string key,string text)
        {
          
            string holder = "";
            int counter = 0;
       for (int i=0;i<text.Length;i++)
            {
                if (counter >= key.Length - 1)
                {
                    counter = 0;
                }
                holder +=  (char)(text[i] ^ key[i%key.Length]);
                
            
            }
            return holder;
        }
        public static string Decode(string key,string text)
        {
            return Encode(key,text);
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string key = "abc";
            Console.WriteLine(Encode(key,text));
            Console.WriteLine(Decode(key, Encode(key,text)));
        }
    }
}
