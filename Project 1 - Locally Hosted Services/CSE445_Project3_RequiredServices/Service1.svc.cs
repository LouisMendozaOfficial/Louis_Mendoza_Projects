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
namespace CSE445_Project3_RequiredServices
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
            mainBodyContent = mainBodyContent.ToLower();

            List<string> maintContentList = mainBodyContent.Split(' ').ToList();

            //Getting the top most searched  words via using Linq
            var orderedWords = maintContentList.GroupBy(x => x).OrderByDescending(x => x.Count());

            string[] top10WordsArrayUnfiltered = orderedWords.Select(x => x.Key).ToArray();
            string[] top10WordsFiltered = new string[10];

            //Using a loop to filter out "words" that aren't alphabetical
            int top10WordsFilteredIndex = 0;

            for (int i = 0; i < top10WordsArrayUnfiltered.Length; i++)
            {
                if (Regex.IsMatch(top10WordsArrayUnfiltered[i], @"^[a-zA-Z']+$") == true && top10WordsFilteredIndex < 10)
                {
                    top10WordsFiltered[top10WordsFilteredIndex] = top10WordsArrayUnfiltered[i];
                    top10WordsFilteredIndex++;
                }
            }
            return top10WordsFiltered;
        }

        public string WordFilter(string inputString)
        {
            //Dont Care Words
            string[] dontCareWords = { "A", "a", "An", "an", "In", "in", "On", "on", "The", "the", "Is", "is", "Are", "are", "Am", "am" };

            //Filtering out the Dont Care Words
            string importantWordsString = string.Join(" ", inputString.Split(' ').Except(dontCareWords));
            return importantWordsString;
        }
    }
}
