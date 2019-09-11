using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Download().Wait();
        }

        public static async Task Download()
        {
            var webClient = new WebClient();
            webClient.DownloadProgressChanged += ((o, e) =>
            {
                double currentMb = (double.Parse(e.BytesReceived.ToString()) / 1024) / 1024;
                double mbToDownload = (double.Parse(e.TotalBytesToReceive.ToString()) / 1024) / 1024;
                Console.WriteLine(e.ProgressPercentage + " " + currentMb + " MB / " + mbToDownload + " MB");

            });
            Console.WriteLine("Started Downloading");
          
            await webClient.DownloadFileTaskAsync(new Uri("https://oqbkip.oloadcdn.net/dl/l/BiswYu0mXuAuPcp2/8Cb0glIp_ig/Borat.2006.BDRip.XviD.AC3-WAR.mp4"), "./myFilm.mp4");
        }
    }
}
