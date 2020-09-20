using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loppuprojekti_MVC.Models
{
    /// <summary>
    /// IUCN class for selecting species based on vulnerability
    /// </summary>
    public class SpeciesCategory
    {
        [JsonProperty("taxon_id")]
        public int Taxonid { get; set; }
        [JsonProperty("scientific_name")]
        public string ScientificName { get; set; }
        [JsonProperty("subspecies")]
        public string Subspecies { get; set; }
        [JsonProperty("rank")]
        public string Rank { get; set; }
        [JsonProperty("subpopulation")]
        public string Subpopulation { get; set; }
    }

    public class SpeciesCategoryRoot
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        /// <summary>"DD", "LC", "NT", "VU", "EN", "CR", "EW", "EX", "LR/lc", "LR/nt", "LR/cd"/// </summary>
        [JsonProperty("category")]
        public string Category { get; set; } //  When querying for "LR/lc", "LR/nt" or "LR/cd" categories, omit the slash character.For example: "LR/lc" becomes "LRlc"
        [JsonProperty("result")]
        public List<SpeciesCategory> Result { get; set; }
    }
}
