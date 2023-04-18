using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Hodina
{
    public class WebScraper
    {
        private const string pattern = "(<h[1-5])*";
        private string html;
        public WebScraper()
        {
            html = DownloadPage(@"https://www.w3schools.com/cs/index.php");
            FilterHTML(html);
        }

        public static string FilterHTML(string html)
        {
            Regex regex = new Regex(pattern);
            foreach (var match in regex.Match(html).Value)
            {
                Console.WriteLine(match);
            }

            return regex.Match(html).Value;
        }

        public static string DownloadPage(string url)
        {
            string res;
            using (WebClient client = new WebClient())
                res = client.DownloadString(url);

            return res;
        }
    }
}
