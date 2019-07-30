using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseKatakanaTest
{
    static class Katakana
    {
        public static string Data;
        public static string[] Groups;

       static string[] katakana = { "ｶｷｸｹｺ","ｻｼｽｾｿ", "ﾀﾁﾂﾃﾄ", "ﾅﾆﾇﾈ", "ﾊﾋﾌﾍﾎ", "ﾏﾐﾑﾒﾓ", "ﾔﾕﾖ", "ﾗﾘﾙﾚﾛ", "ﾜｦ", "ﾝ" };



        public static void KTR(int group)
        {
           
            for (int i = 0; i < 15; i++)
            {
                Random rnd = new Random();
                string holder = katakana[rnd.Next(0,group)];
                Console.Write(holder[rnd.Next(0,holder.Length)]);
                string otherHolder += holder;
            }
            
            
        }
     
    }
    class Romaji
    {
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CultureInfo.CurrentUICulture = new CultureInfo("ja-JP", false);
            Katakana.KTR(3);
            Console.WriteLine("");
            

        }
    }
}
