using System;
using System.Collections.Generic; 
using System.Linq;
using System.Net;

namespace LinkCrawler
{
    class LinkCollector
    {
        public class Link
        {
            public string link { get; private set; }
            public string root { get; private set; }
            public Link(string link)
            {
                this.link = link;
                int start = 8;
                int end = link.Length;
                if (link.IndexOf('/', start) > 0)
                    end = link.IndexOf('/', start);
                root = link.Substring(0, end).Trim();
            }
        }

        public bool exceptPdf { get; set; }

        public LinkCollector(bool exceptPdf = true)
        {
            this.exceptPdf = exceptPdf;
        }
        private HtmlAgilityPack.HtmlDocument LoadPage(string AUrl)
        {
            WebClient client = new WebClient();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            try
            {
                Uri url = new Uri(AUrl);
                string html = client.DownloadString(url);
                if (!((exceptPdf) && (AUrl.EndsWith(".pdf") || html.StartsWith("%PDF"))))
                    if ((html.ToLower().Contains("<!doctype html")))
                        document.LoadHtml(html);
                    else
                        document = null;
            }
            catch (Exception ex)
            {
                document = null;
                Console.WriteLine("Error:" + ex.Message);
            }
            return document;
        }


        public List<Link> FindAllResults(string strQuery)
        {
            List<Link> result = FindResultsGoogle(strQuery);
            result = result.Union(FindResultsBing(strQuery)).ToList();
            result = result.Union(FindResultsYahoo(strQuery)).ToList();
            return result;
        }

        public List<Link> FindResultsGoogle(string strQuery, int count = 50)
        {
            List<Link> result = null;
            HtmlAgilityPack.HtmlDocument document = LoadPage("http://www.google.com/search?q=" + strQuery + "&num=" + count.ToString());
            try
            {
                result = document.DocumentNode.SelectNodes("//div[@class='s']//div[@class='kv']//cite").Select(node => new Link(CorrectLink(node.InnerText))).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public List<Link> FindResultsBing(string strQuery)
        {
            List<Link> result = null;
            HtmlAgilityPack.HtmlDocument document = LoadPage("http://www.bing.com/search?q=" + strQuery);
            try
            {
                result = document.DocumentNode.SelectNodes(@"//*[@id=""b_results""]/li/div/h2/a").Select(node => new Link(CorrectLink(node.Attributes["href"].Value))).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public List<Link> FindResultsYahoo(string strQuery, int count = 40)
        {
            List<Link> result = null;
            HtmlAgilityPack.HtmlDocument document = LoadPage("http://search.yahoo.com/search?n=" + count.ToString() + "&p=" + strQuery);
            try
            {
                result = document.DocumentNode.SelectNodes("//span[@class=' fz-15px fw-m fc-12th wr-bw lh-15']").Select(node => new Link(CorrectLink(node.InnerText))).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        private string CorrectLink(string strUrl, string Aurl = "")
        {
            string result;
            if (strUrl.StartsWith("http"))
            {
                result = strUrl;
            }
            else
            {
                if (Aurl.Length > 0)
                    result = Aurl + strUrl;
                else
                    result = "http://" + strUrl;
            }
            return result;
        }

        public List<Link> GetLinksFromAPage(string Aurl, bool outerLinks = true)
        {
            List<Link> result = null;
            HtmlAgilityPack.HtmlDocument document = LoadPage(Aurl);
            try
            {
                result = document.DocumentNode.SelectNodes("//a[@href]").Select(node => new Link(CorrectLink(node.Attributes["href"].Value, Aurl))).ToList();
                result = result.GroupBy(x => x.link).Select(y => y.First()).ToList();
                if (outerLinks)
                    result = result.Where(x => !x.link.Contains(Aurl)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public List<string> GetRecursiveLinks(string query,int depth)
        {
            List<string> result = new List<string>();
            try
            {
                List<LinkCollector.Link> linklist = FindAllResults(query);
                for (int i = 0; i < depth; i++)
                {
                    int last = 0;
                    List<LinkCollector.Link> newlist = new List<LinkCollector.Link>();
                    for (int j = last; j < linklist.Count; j++)
                    {
                        Console.WriteLine(j + " : " + linklist[j].link);
                        var pagelinks = GetLinksFromAPage(linklist[j].link);
                        if (pagelinks != null)
                            newlist = newlist.Union(pagelinks).ToList();
                    }
                    last = linklist.Count;
                    linklist = linklist.Union(newlist).ToList();
                } 
                result=linklist.GroupBy(x => x.root).Select(y => y.Key).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            return result;
        }
    }
}
