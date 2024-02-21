using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Xml;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Caching.Memory;


namespace CSE446_Assignment6
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        //Setting up the cache
        private readonly IMemoryCache _cache;
        public MainPage()
        {
            InitializeComponent();
            _cache = new MemoryCache(new MemoryCacheOptions() { });
        }

        private async void AbsoluteValueButton_Clicked(object sender, EventArgs e)
        {
            string userInput = AbsoluteValue_Entry.Text;

            //If the input was repeated and found in the cache in 10 seconds
            string cacheExists = Get<string>("" + userInput);
            if (cacheExists != null && userInput.Equals(cacheExists))
            {
                Cache_Label.Text = "The API call was not made, the user used an input that was cached within the past 10 seconds of: " + cacheExists;
            }

            else
            {
                //Setting up the client
                HttpClient client = new HttpClient();

                string result;
                string absoluteValue;

                try
                {
                    //Reseting the cache label
                    Cache_Label.Text = "";

                    //Calling the restful service
                    var response = await client.GetAsync("https://venus.sod.asu.edu/WSRepository/Services/WcfRestService4/Service1/AbsValue?x=" + userInput);
                    response.EnsureSuccessStatusCode();
                    result = (await response.Content.ReadAsStringAsync()).Replace(@"""", "");

                    //Caching
                    DateTimeOffset now = DateTimeOffset.Now;
                    DateTimeOffset tenSecondsLater = now.AddSeconds(10);
                    Set("" + userInput, userInput, tenSecondsLater);

                    //Formatting
                    Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
                    absoluteValue = reg.Replace(result, " ");

                    //Changing the label to the absolute value
                    AbsoluteValue_Label.Text = absoluteValue;
                }

                catch (HttpRequestException ex)
                {
                    absoluteValue = ex.ToString();

                    //Changing the label to the absolute value
                    AbsoluteValue_Label.Text = absoluteValue;
                }

            }
            
        }

        private async void RandomStringButton_Clicked(object sender, EventArgs e)
        {
            //Setting up the client
            HttpClient client = new HttpClient();

            string result;
            string randomString;

            try
            {
                //Calling the restful service
                var response = await client.GetAsync("https://venus.sod.asu.edu/WSRepository/Services/RandomString/Service.svc/GetRandomString/8");
                response.EnsureSuccessStatusCode();
                result = (await response.Content.ReadAsStringAsync()).Replace(@"""", "");

                //Formatting
                Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
                randomString = reg.Replace(result, " ");

            }

            catch (HttpRequestException ex)
            {
                randomString = ex.ToString();
            }

            //Changing the label to the random string
            RandomString_Label.Text = randomString;

        }

        //Cache set method
        public void Set<T>(string key, T value, DateTimeOffset absoluteExpiry)
        {
            _cache.Set(key, value, absoluteExpiry);
        }

        //Cache get method
        public T Get<T>(string key)
        {
            if (_cache.TryGetValue(key, out T value))
                return value;
            else
                return default(T);
        }
    }
}