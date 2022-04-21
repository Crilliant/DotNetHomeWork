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

namespace Crawler
{
    
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public int sum { get; set; } = 10;
        public string startUrl { get; set; } = "http://www.cnblogs.com/dstang2000/";

        public event Action<string> BeginHandler;


        public void StartCrawler()
        {
            urls.Add(startUrl, false);    // 加入没爬的初始页面, (key, value)
            //new Thread(Crawl).Start();
            Crawl();
        }

        private void Crawl()
        {
            BeginHandler("开始爬行了.... \r\n");

            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url])  continue;  // 已经爬过了
                    current = url;
                }

                if (current == null || count > sum)     // 表中没有新的url或者爬的数量足够
                    break;
                BeginHandler("爬行" + current + "页面!\r\n");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;    // 已爬过的数量
                Parse(html, current);// 解析本网页, 提取出其中的超链接，并加入hashtable。
                BeginHandler("爬行结束。\r\n");
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
                BeginHandler(ex.Message + "\r\n");
                return "";
            }
        }

        private void Parse(string html, string current)
        {
            // string strRef = @"(href|HREF)\s*=\s*[" + "\"'][^" + "\"'#>]+[" + "'\"]";
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            // strRef匹配：<a href="http://abc">
            MatchCollection matches = new Regex(strRef).Matches(html);
            string newPath = "";

            foreach (Match match in matches)
            {
                newPath = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>', ' ');   // 从=后面的字符开始，trim修建开头结尾的"'#>\s
                //路径不是想要的类型
                if ( !IsWantedType(newPath) ) continue;
                newPath = RelativeToAbsolute(newPath, current);
                if (urls[newPath] == null)   urls[newPath] = false;
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
            string AbsolutePattern = @"^(http|https)";
            if (Regex.IsMatch(url, AbsolutePattern))    return url;

            string thisDirPattern = @"^(./|/)(?<nakePath>.+)";
            string upperDirPattern = @"^(../)(?<nakePath>.+)";
            string goUpperDir = @"(.*)(/.*)$";
            
            if(Regex.IsMatch(url, thisDirPattern))
            {
                MatchCollection match = Regex.Matches(url, thisDirPattern);
                url = root + "/" + match[0].Groups["nakePath"].Value;
            }
            else    //需要跳转到上一级目录
            {
                MatchCollection match = Regex.Matches(url, upperDirPattern);
                MatchCollection rootMatch = Regex.Matches(root, goUpperDir);
                url = rootMatch[0] + "/" + match[0].Groups["nakePath"].Value;
            }

            return url;
        }
    }
}
