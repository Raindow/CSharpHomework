using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;




namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            myCrawler.Urls.Add(startUrl, false);
            myCrawler.Crawl();
            Console.ReadKey();
        }
    }
    class Crawler
    {
        //private Hashtable urls = new Hashtable(); ///书中源代码；
        private Dictionary<string, bool> urls = new Dictionary<string, bool>();
        private int count = 0;

        public Dictionary<string, bool> Urls { get => urls; set => urls = value; }

        private void MyCrawl()
        {
            try {
                Console.WriteLine("开始爬行了......");
                while(count != Urls.Count) {
                    Parallel.ForEach<string>(Urls.Keys.Where(url => Urls[url] == false), url => {
                        Console.WriteLine("当前线程：" + Thread.CurrentThread.ManagedThreadId);
                        Console.WriteLine("爬行" + url + "页面！");
                        string html = DownLoad(url);
                        Urls[url] = true;
                        count++;
                        Parse(html);
                    });
                }

                {   //书上原代码
                    //while (true) {
                    //    string current = null;
                    //    foreach (string url in Urls.Keys) {
                    //        if ((bool)Urls[url]) continue;
                    //        current = url;
                    //    }
                    //    if (current == null || count > 10) break;
                    //    Console.WriteLine("爬行" + current + "页面！");
                    //    string html = DownLoad(current);
                    //    Urls[current] = true;
                    //    count++;
                    //    Parse(html);
                    //}
                }
                {   //在hashtable的基础上的更改
                    //List<string> myList = new List<string>();
                    //while ((myList.Count) != (urls.Keys.Cast<string>().ToList().Count)) {
                    //    myList = urls.Keys.Cast<string>().ToList();
                    //    var waitToDownloadUrls = from url in myList
                    //                             where (bool)Urls[url] == false
                    //                             select url;
                    //    Parallel.ForEach<string>(waitToDownloadUrls, url => {
                    //        Console.WriteLine("当前线程：" + Thread.CurrentThread.ManagedThreadId);
                    //        Console.WriteLine("爬行" + url + "页面！");
                    //        string html = DownLoad(url);
                    //        Urls[url] = true;
                    //        count++;
                    //        Parse(html);
                    //    });
                    //}
                }
            }
            catch (AggregateException ex){
                Console.WriteLine(ex.Message);
            }

        }

        public void Crawl()
        {
            MyCrawl();
        }
        public string DownLoad(string url)
        {
            try {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string filename = count.ToString();
                File.WriteAllText(filename, html, Encoding.UTF8);
                return html;
            }catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void Parse(string html)
        {
            string strRef = @"(href | HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches) {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ' ', '>');
                if (strRef.Length == 0) continue;
                Urls[strRef] = false;
            }
        }

    }
}
