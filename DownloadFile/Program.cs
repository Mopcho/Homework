using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(url, @"C:\Test\image.png");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Address");
            }
               
        }
    }
}
