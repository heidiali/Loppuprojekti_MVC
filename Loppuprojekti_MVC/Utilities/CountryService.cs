using Loppuprojekti_MVC.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using NLog;
using System;

namespace Loppuprojekti_MVC.Utilities
{

    public class CountryService
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        string baseUrl = "http://apiv3.iucnredlist.org/api/v3/";
        string token = "?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee";
        string url = "";

        public List<CountryList> Countries()
        {
            try
            {
                string json = "";
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    url = baseUrl + "country/list" + token;

                    var response = client.GetAsync(url).Result;
                    json = response.Content.ReadAsStringAsync().Result;
                    {
                        CountryListRoot cl;
                        cl = JsonConvert.DeserializeObject<CountryListRoot>(json);

                        return cl.Countries;
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "Endangered Planet, issue in querying Countries");
                return null;
            }

        }

        //TODO: Very heavy and slow, several queries need to be made.
        //TODO: Better to download it to App_Data from which it's easier to access
        //public List<CountrySpecies> Country(string isoCode) // parameter needed for the var response url below
        //{
        //    string json = "";

        //    using (var client = new HttpClient())
        //    {
        //        CountryList cl = new CountryList();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        var response = client.GetAsync($"http://apiv3.iucnredlist.org/api/v3/country/getspecies/{isoCode}?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee").Result;
        //        //var response = client.GetAsync($"http://apiv3.iucnredlist.org/api/v3/country/getspecies/AZ?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee").Result;
        //        var responseString = response.Content.ReadAsStringAsync().Result;
        //        json = responseString;
        //        {
        //            CountriesRoot ct;
        //            ct = JsonConvert.DeserializeObject<CountriesRoot>(json);
        //            return ct.Result;
        //        }
        //    }
        //}

        //TODO: Very heavy and slow, several queries need to be made.
        //TODO: Better to download it to App_Data from which it's easier to access
        public List<CountrySpecies> Country(string isoCode)
        {
            string json = "";

            using (StreamReader sr = new StreamReader(@"AdditionalData/CountryApi/" + isoCode + ".txt"))
            {
                CountryList cl = new CountryList();
                json = sr.ReadToEnd();
                CountriesRoot ct;
                ct = JsonConvert.DeserializeObject<CountriesRoot>(json);
                return ct.Result;
                //return ct.Result;

            }


        }

    }
}
