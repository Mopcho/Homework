using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;

namespace URLParse
{
    class Site
    {
        public string Url { get; set; }
    }
  
    class Program
    {
        public static string Request(string url)
        {
            WebRequest request = WebRequest.Create(url);

            WebResponse resp = request.GetResponse();

            string result = "";
            using (Stream stream = resp.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string holder = "";
            using (StreamReader sr=new StreamReader(file))
            {
                holder+=sr.ReadToEnd();
            }
            string[] urls = holder.Split('\n');
            string[] urlsHTML = new string[urls.Length]; 
           for (int i=0;i<urls.Length;i++)
            {
                urlsHTML[i] = Request(urls[i]);
            }
          
        }
    }
}
