using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;

namespace CSE445_Project3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] TopTenWords(string url)
        {

            //Getting the content of the webpage
            WebClient client = new WebClient();
            string webContent = client.DownloadString(url);


            //Filtering out the content to get the main text, ignoring stuff like dividers and the like
            Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            string mainBodyContent = reg.Replace(webContent, " ");
            mainBodyContent = HttpUtility.HtmlDecode(mainBodyContent);

            //Getting the top most searched  words via using Linq
            var orderedWords = mainBodyContent.Split(' ').GroupBy(x => x).Select(x => new { KeyField = x.Key, Count = x.Count() }).OrderByDescending(x => x.Count).Take(10);
            string[] top10WordsArray = orderedWords.Select(x => x.ToString()).ToArray();

            foreach (var item in top10WordsArray)
            {
                Console.WriteLine(item.ToString());
            }

            return top10WordsArray;
        }

        public string WordFilter(string inputString)
        {
            string[] dontCareWords = { "A", "a", "An", "an", "In", "in", "On", "on", "The", "the", "Is", "is", "Are", "are", "Am", "am" };
            string importantWordsString = string.Join(" ", inputString.Split(' ').Except(dontCareWords));
            return importantWordsString;
        }
    }
}
