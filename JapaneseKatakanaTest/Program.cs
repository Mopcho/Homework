using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseKatakanaTest
{
   
    static class RTK
    {
        public static string Romaji="a i u e o ka ki ku ke ko ga gi gu ge go sa shi su se so za ji zu ze zo ta chi tsu te to da ji zu de do na ni nu ne no ha hi fu he ho ba bi bu be bo pa pi pu pe po ma mi mu me mo ya yu yo ra ri ru re ro wa wo n";
        public static string[] MRomaji = Romaji.Split(' ');
        public static void Test(int group,int wordCount)
        {

            Random rnd = new Random();
            for (int i=0;i<wordCount;i++)
            {
                
                Console.Write("{0} ",MRomaji[rnd.Next(0,group)]);
            }
            Console.WriteLine();
        }
    }
  
    class Program
    {
        public static void Main(string[] args)
        {
            //5 = 1st Group
            //15 = 2nd group
            //25 = 3rd group
            //35 = 4th group
            //40 = 5th group
            //55 = 6th group
            //60 = 7th group
            //63 = 8th group
            //68 = 9th group
            //70 = 10th group
            //71 = 11th group
            int wordCount = int.Parse(Console.ReadLine());
            RTK.Test(35,wordCount);
        }
    }
}
