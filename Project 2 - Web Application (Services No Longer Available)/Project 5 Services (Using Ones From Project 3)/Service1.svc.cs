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

namespace CSE_445_Project3_Assignment6_NonRESTFUL_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //Required Service (15 Points) - Louis Mendoza
        public string TopTenWords(string url)
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

            return string.Join(", ", top10WordsFiltered);
        }

        //Elective Service - Louis Mendoza
        public int AverageSentenceLength(string url)
        {
            //Getting the content of the webpage
            WebClient client = new WebClient();
            string webContent = client.DownloadString(url);

            //Filtering out the content to get the main text, ignoring stuff like dividers and the like
            Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            string mainBodyContent = reg.Replace(webContent, " ");
            mainBodyContent = HttpUtility.HtmlDecode(mainBodyContent);
            mainBodyContent = mainBodyContent.ToLower();

            //Getting the total number of words and the total number of sentences
            List<string> wordlist = new List<string>();
            int numberOfSentences = 0;

            string[] wordArray = mainBodyContent.Split(' ');

            char sentenceEnder = '.';

            int frequency = mainBodyContent.Count(f => (f == sentenceEnder));

            int averageSentenceLength = wordArray.Length / frequency;

            return averageSentenceLength;
        }

        //Elective Service - Louis Mendoza
        public int NumberOfUnimportantWords(string url)
        {
            //Getting the content of the webpage
            WebClient client = new WebClient();
            string webContent = client.DownloadString(url);

            //Filtering out the content to get the main text, ignoring stuff like dividers and the like
            Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            string mainBodyContent = reg.Replace(webContent, " ");
            mainBodyContent = HttpUtility.HtmlDecode(mainBodyContent);
            mainBodyContent = mainBodyContent.ToLower();

            //Finding the number of unimportant words
            string word1 = "a";
            string word2 = "an";
            string word3 = "in";
            string word4 = "on";
            string word5 = "the";
            string word6 = "is";
            string word7 = "are";
            string word8 = "am";
            int Count = 0;
            Count = Regex.Matches(mainBodyContent, word1).Count;
            Count = Count + Regex.Matches(mainBodyContent, word2).Count;
            Count = Count + Regex.Matches(mainBodyContent, word3).Count;
            Count = Count + Regex.Matches(mainBodyContent, word4).Count;
            Count = Count + Regex.Matches(mainBodyContent, word5).Count;
            Count = Count + Regex.Matches(mainBodyContent, word6).Count;
            Count = Count + Regex.Matches(mainBodyContent, word7).Count;
            Count = Count + Regex.Matches(mainBodyContent, word8).Count;

            return Count;
        }

        //Required Service (15 Points) - Louis Mendoza
        public string WordFilter(string inputString)
        {
            //Dont Care Words
            string[] dontCareWords = { "A", "a", "An", "an", "In", "in", "On", "on", "The", "the", "Is", "is", "Are", "are", "Am", "am" };

            //Filtering out the Dont Care Words
            string importantWordsString = string.Join(" ", inputString.Split(' ').Except(dontCareWords));
            return importantWordsString;
        }


        //Elective Service - Louis Mendoza
        public string NumberOfSentences(string url)
        {

            //Getting the content of the webpage
            WebClient client = new WebClient();
            string webContent = client.DownloadString(url);

            //Filtering out the content to get the main text, ignoring stuff like dividers and the like
            Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            string mainBodyContent = reg.Replace(webContent, " ");
            mainBodyContent = HttpUtility.HtmlDecode(mainBodyContent);
            mainBodyContent = mainBodyContent.ToLower();

            //Finding the number of sentences
            char sentenceEnder = '.';

            int frequency = mainBodyContent.Count(f => (f == sentenceEnder));

            return frequency.ToString();
        }
    }
}
