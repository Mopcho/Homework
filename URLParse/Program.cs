using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace URLParse
{
    class Site
    {
        public string Url { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string holder = "";
            using (StreamReader sr=new StreamReader(file))
            {
                holder+=sr.ReadToEnd();
            }
            string[] urls = holder.Split('\n');
            List<Site> sites = new List<Site>();
            for (int i=0;i<urls.Length;i++)
            {
                Site mySite = new Site();
                mySite.Url = urls[i];
                sites.Add(mySite);
            }
          
        }
    }
}
