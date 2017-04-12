using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    public interface iScraper
    {
        string RegexPattern { get; }
        string Url { get; }
    }

    public class Scraper : iScraper
    {
        public string RegexPattern { get; set; }
        public string Url { get; set; }
        
        public string GetHtml()
        {
            return new WebClient().DownloadString(Url);
        }
        


    }
}
