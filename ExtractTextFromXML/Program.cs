using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTextFromXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string file2 = Console.ReadLine();
            string holder;
            string text = "";
            int check1 = 0;
            int check2 = 0;
            bool lever = true;
            using (StreamReader sr=new StreamReader(file))
            {
                holder = sr.ReadToEnd();
            }
            for (int i=0;i<holder.Length;i++)
            {
                if (holder[i]=='>')
                {
                    int a = i;
                    while (lever)
                    {
                        if (holder[a] == '<')
                        {
                            for (int b = check1; b < check2; b++)
                            {
                                text +=" "+ holder[b];
                            }
                            lever = false;
                        }
                        else
                        {
                            check2++;
                        }

                        a++;
                        if (a>=holder.Length)
                        {
                            break;
                        }
                    }
                    lever = true;
                    check1 = i+2;
                    check2 = i+1;
                }
             else
                {
                    check1++;
                    check2++;
                }

                
            }
            using (StreamWriter sw=new StreamWriter(file2)) {
                sw.Write(text);
            }
        }
    }
}
