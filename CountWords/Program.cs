using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"C:\Users\PC\Desktop\Words.txt";
            string file2 = @"C:\Users\PC\Desktop\Test.txt";
            string file3= @"C:\Users\PC\Desktop\Result.txt";
            string wordsHolder;
            string textHolder;
            using (StreamReader sr=new StreamReader(file1))
            {
                wordsHolder = sr.ReadToEnd();
            }
            using (StreamReader sr1=new StreamReader(file2))
            {
                textHolder = sr1.ReadToEnd();
            }
            string[] words = wordsHolder.Split(' ');
            string[] text = textHolder.Split(' ');
            int[] countWords = new int[words.Length];
            int counter = 0;
            for (int i=0;i<words.Length;i++)
            {
                for (int a=0;a<text.Length;a++)
                {
                    if (words[i]==text[a])
                    {
                        counter++;
                    }
                }
                countWords[i] = counter;
                counter = 0;
            }
            int small = countWords[0];
            int holderA = 0;
            string[] sortedWordsStr = new string[countWords.Length];
            int[] sortedWords = new int[countWords.Length];
            for (int i=0;i<countWords.Length;i++)
            {
                for (int a=1;a<countWords.Length;a++)
                {
                    if (small>countWords[a])
                    {
                        small = countWords[a];
                        holderA = a;
                    }
                    sortedWordsStr[i] = words[holderA];
                    countWords[holderA] = 111111;
                    holderA = 0;
                    sortedWords[i] = small;
                    small = countWords[0];
                }
            }
            using (StreamWriter sw = new StreamWriter(file3))
            {
                for (int i = 0; i < sortedWords.Length; i++)
                {
                    sw.WriteLine("{0} {1}", sortedWords[i], sortedWordsStr[i]);
                }
            }
        }
       
    }
}
