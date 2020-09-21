using Loppuprojekti_MVC.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NLog;
using Newtonsoft.Json;

namespace Loppuprojekti_MVC.Utilities
{
    /// <summary> 
    /// IUCN REST API connection
    /// </summary>
    public class RestUtilities
    {
        //TODO: Add error handling
        //TODO: Put in ConfigurationManager AppSettings and call from there, shouldn't be visible in source code

        private static Logger logger = LogManager.GetCurrentClassLogger();
        string baseUrl = "http://apiv3.iucnredlist.org/api/v3/";
        string token = "?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee";
        string url = "";

        //All species api/v3/species/page/
        public List<Species> Species()
        {
            try
            {
                string json = "";
                using (var client = new HttpClient())
                {
                    //TODO: Query for all pages, how many? Very long, should be queryed separately to App_Data again
                    url = baseUrl + "species/page/" + 0 + token;

                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.GetAsync(url).Result;
                    json = response.Content.ReadAsStringAsync().Result;
                }
                SpeciesRootObject result = JsonConvert.DeserializeObject<SpeciesRootObject>(json);
                return result.Result;
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "Endangered Planet, issue in querying Species");
                return null;
            }

        }

        //Individual species with scientific name species/{searchTerms}
        public List<IndividualSpecies> SingleSpecies(string searchTerms)
        {
            try
            {
                string json = "";
                using (var client = new HttpClient())
                {
                    url = baseUrl + "species/" + searchTerms + token;
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.GetAsync(url).Result;
                    json = response.Content.ReadAsStringAsync().Result;
                }

                IndividualSpeciesRoot result = JsonConvert.DeserializeObject<IndividualSpeciesRoot>(json);
                return result.Result;
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "Endangered Planet RestUtilities issue in SingleSpecies");
                return null;
            }

        }

        //Individual species with id, species/{searchTerms}
        public List<IndividualSpecies> SingleSpeciesId(int searchTerms)
        {
            try
            {
                string json = "";

                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    url = baseUrl + "species/id/" + searchTerms + token;
                    var response = client.GetAsync(url).Result;
                    json = response.Content.ReadAsStringAsync().Result;
                }
                IndividualSpeciesRoot result = JsonConvert.DeserializeObject<IndividualSpeciesRoot>(json);
                return result.Result;
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "Endangered Planet RestUtilities issue in SingleSpecies");
                return null;
            }

        }

        //GET narrative info for a species
        // species/narrative/{searchTerms}
        public List<SpeciesNarrative> SingleNarrative(string searchTerms)
        {
            try
            {
                string json = "";

                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    url = baseUrl + "species/narrative/" + searchTerms + token;
                    var response = client.GetAsync(url).Result;
                    json = response.Content.ReadAsStringAsync().Result;
                }
                SpeciesNarrativeRoot result = JsonConvert.DeserializeObject<SpeciesNarrativeRoot>(json);
                return result.Result;
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "Endangered Planet RestUtilities issue in SingleNarrative");
                return null;
            }

        }

        //GET link to IUCNpage of the animal
        // /weblink/
        //http://apiv3.iucnredlist.org/api/v3/weblink/loxodonta%20africana
        public Link IUCNurl(string searchTerms)
        {
            try
            {
                string json = "";

                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    url = baseUrl + "weblink/" + searchTerms;
                    var response = client.GetAsync(url).Result;
                    json = response.Content.ReadAsStringAsync().Result;
                }

                Link res = JsonConvert.DeserializeObject<Link>(json);
                return res;
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "Endangered Planet RestUtilities issue in IUCNurl");
                return null;
            }

        }

        //TODO: Get this working for statistics
        // GET IUCN for count of species in different vulnerability classes
        //searchTerm: vulnerability class
        public List<SpeciesCategory> SCategory(string searchTerms)
        {
            string json = "";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync($"http://apiv3.iucnredlist.org/api/v3/species/category/{searchTerms}?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee").Result;
                //var response = client.GetAsync($"http://apiv3.iucnredlist.org/api/v3/species/category/VU?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee").Result;

                var responseString = response.Content.ReadAsStringAsync().Result;
                json = responseString;
            }

            SpeciesCategoryRoot res;
            res = JsonConvert.DeserializeObject<SpeciesCategoryRoot>(json);
            return res.Result;

        }

    }
}
