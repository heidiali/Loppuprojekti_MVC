using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loppuprojekti_MVC.Models
{
    //We chose to have nice C# names, thus JSOn serializer cannot recognize them (they are not precisely the same) and they are defined with [JsonProperty("")].
    //Species by country
    // http://apiv3.iucnredlist.org/api/v3/country/getspecies/AZ?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee
    

    public class CountrySpecies
    {
        /// <summary>The TaxonId property represents the Id for teh Species/Taxon.</summary>
        /// <value>The TaxonId property gets set with the int of the GET call.</value>
        [JsonProperty("taxonid")]
        public int Taxonid { get; set; }
        [JsonProperty("scientific_name")]
        public string ScientificName { get; set; } //scientific name of the species
        [JsonProperty("subspecies")]
        public string Subspecies { get; set; } //only if presents a certain subspecies/variety/form
        [JsonProperty("rank")]
        public string Rank { get; set; } //taxonomic ranks, either spp, var or for : spp (multiple species eg. Canis spp - multiple Dog species), var (varietas), for (?)
        [JsonProperty("subpopulation")]
        public object Subpopulation { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        public string CommonName { get; set; }
    }

    /// <summary> Red List available countries </summary>
    public class CountriesRoot
    {
        /// <summary>The Isocode property represents the id for the Country.</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; } //full country name e.g. "Uzbekistan"
        /// <summary> Describes all the species in a given country </summary>
        public List<CountrySpecies> Result; //describes the species in one country
    }
}
