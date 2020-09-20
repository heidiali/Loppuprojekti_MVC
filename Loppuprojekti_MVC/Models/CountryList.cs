using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Loppuprojekti_MVC.Models
{
    public class CountryList
    {
        /// <summary>The Isocode property represents the two-letter country abbreviation</summary>
        [JsonProperty("isocode")]
        public string IsoCode { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CountryListRoot
    {
        [JsonProperty("count")]
        public int CountryCount { get; set; }
        [JsonProperty("results")]
        public List<CountryList> Countries { get; set; }
    }
}
