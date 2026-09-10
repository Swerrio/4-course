using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ParallelForeachApplication
{
    class Program
    {
        private static void Download(string url)
        {
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                Console.WriteLine("Скачиваем : " + url);
                client.DownloadString(url);
            }
            catch (WebException ex)
            {
                Console.WriteLine("Недоступен : " + url + " (" + ex.Message + ")");
            }
        }

        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            ServicePointManager.DefaultConnectionLimit = 20;

            List<string> urls = new List<string>()
            {
                "http://intuit.ru",
                "http://rbc.ru",
                "http://ozon.ru",
                "http://google.com",
                "http://mail.ru",
                "http://lenta.ru"
            };

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

            foreach (string url in urls)
            {
                Download(url);
            }

            long elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine("Затраченное время в миллисекундах: {0}", elapsed);
            sw.Stop();

            Console.WriteLine("============================");

            sw.Restart();

            Parallel.ForEach(urls, url =>
            {
                Download(url);
            });

            elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine("Затраченное время в миллисекундах: {0}", elapsed);
            sw.Stop();

            Console.ReadLine();
        }
    }
}
