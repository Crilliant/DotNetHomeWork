using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ParallelCrawler
{
    class Crawler
    {

        private ConcurrentDictionary<string, bool> visited 
            = new ConcurrentDictionary<string, bool>();
        private ConcurrentQueue<string> urls 
            = new ConcurrentQueue<string>();

        private int count = 0;
        public int sum { get; set; } = 20;
        public string startUrl { get; set; } = "http://www.cnblogs.com/dstang2000/";
       

        public event Action<string> LogHandler;


        public void StartCrawler()
        {
                       
            // 加入没爬的初始页面, (key, value)            
            urls.Enqueue(startUrl);
            visited[startUrl] = false;
            LogHandler("开始爬行了.... \r\n");

            // 需要查看一下task状态，可能不是5个同时跑
            // Todo
            Task[] tasks = {
                Task.Run( () => Crawl() ),
                Task.Run( () => Crawl() ),
                Task.Run( () => Crawl() ),
                Task.Run( () => Crawl() ),
                Task.Run( () => Crawl() )
                    };

        }

        private void Crawl()
        {
            
            while (true)    // 不要写while(true)
            {
                string current = null;
                
                // 已经爬过了               
                foreach(string url in urls)
                {
                    // 未能移除队列第一个url
                    if (!urls.TryDequeue(out current)) continue;
                    break;  // 取到一个有效url

                }
                if (current == null || count > sum)     // 表中没有新的url或者爬的数量足够
                    break;

                LogHandler("爬行" + current + "页面!\r\n");
                string html = DownLoad(current); // 下载
                visited[current] = true;
                
                //Todo: 查看影响效率,怀疑不能真的lock visited

                lock (this)
                {
                    count++;// 已爬过的数量
                }
                Parse(html, current);// 解析本网页, 提取出其中的超链接，并加入hashtable。
                LogHandler("爬行结束。\r\n");
                
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                LogHandler(ex.Message + "\r\n");
                return "";
            }
        }

        private void Parse(string html, string current)
        {
            string strRef = @"(href|HREF)\s*=\s*[" + "\"'][^" + "\"'#>]+[" + "'\"]";
            //string strRef = @"(href|HREF)[ ]*=[ ]*[""'](?<url>^""'#>)+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            string newPath = "";

            foreach (Match match in matches)
            {
                //newPath = match.Groups["url"].Value;
                newPath = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>', ' ');   // 从=后面的字符开始，trim修建开头结尾的"'#>\s


                //路径不是想要的类型
                if (!IsWantedType(newPath)) continue;
                newPath = RelativeToAbsolute(newPath, current);
                if (!visited.ContainsKey(newPath)) 
                {
                    urls.Enqueue(newPath);
                    visited[newPath] = false;
                }  
            }
        }
        /// <summary>
        /// 只有当爬取的是html/html/aspx/jsp等网页时，才解析并爬取下一级URL。
        /// </summary>
        private bool IsWantedType(string url)
        {
            string pattern = @".(html|htm|aspx|php|jsp)$";
            return Regex.IsMatch(url, pattern);
        }

        /// <summary>
        /// 获得绝对路径。
        /// 相对地址(test/page.html, ./test/page.html,
        /// ../test2/page2.html, /test3/page.html）
        /// </summary>
        /// <param name="url">新的路径</param>
        /// <param name="root">原网页地址</param>
        /// <returns>返回绝对路径</returns>
        private string RelativeToAbsolute(string url, string root)
        {
            if (url.Contains("://")) return url;

            string thisDirPattern = @"^(./|/)(?<nakePath>.+)";
            string upperDirPattern = @"^(../)(?<nakePath>.+)";
            string goUpperDir = @"(.*)(/.*)$";

            if (Regex.IsMatch(url, thisDirPattern))
            {
                MatchCollection match = Regex.Matches(url, thisDirPattern);
                url = root + "/" + match[0].Groups["nakePath"].Value;
            }
            else    //需要跳转到上一级目录 !递归../../../
            {
                MatchCollection match = Regex.Matches(url, upperDirPattern);
                MatchCollection rootMatch = Regex.Matches(root, goUpperDir);
                url = rootMatch[0] + "/" + match[0].Groups["nakePath"].Value;
            }

            return url;
        }
    }
}
