using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loppuprojekti_MVC.Models
{
    //We chose to have nice C# names, thus JSOn serializer cannot recognize them (they are not precisely the same) and they are defined with [JsonProperty("")].

    /// <summary> RedList Species </summary>
    public class Species
    {
        /// <summary>The TaxonId property represents the Id for the Species/Taxon.</summary>
        /// <value>The TaxonId property gets set with the int of the GET call.</value>
        [JsonProperty("taxon_id")]
        public int Taxonid { get; set; }
        [JsonProperty("kingdom_name")]
        public string KingdomName { get; set; }
        [JsonProperty("phylum_name")]
        public string PhylumName { get; set; }
        [JsonProperty("class_name")]
        public string ClassName { get; set; }
        [JsonProperty("order_name")]
        public string OrderName { get; set; }
        [JsonProperty("family_name")]
        public string FamilyName { get; set; }
        [JsonProperty("genus_name")]
        public string GenusName { get; set; }
        [Display(Name = "Scientific Name")]
        [JsonProperty("scientific_name")]
        public string ScientificName { get; set; }
        [JsonProperty("infra_rank")]
        public string InfraRank { get; set; }
        /// <summary>Sub-species, if available.</summary>
        [JsonProperty("infra_name")]
        public string InfraName { get; set; }
        /// <summary> Population name, if available. </summary>
        [JsonProperty("population")]
        public string Population { get; set; }
        /// <summary> The Red List Category </summary>
        [JsonProperty("category")]
        public string Category { get; set; }
    }

    /// <summary>The SpeciesRootObject property represents the JSON Objects the GET returns.</summary>
    public class SpeciesRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("page")]
        public string Page { get; set; }
        [JsonProperty("result")]
        public List<Species> Result { get; set; }
    }
}