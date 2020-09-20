using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loppuprojekti_MVC.Models
{
    // http://apiv3.iucnredlist.org/api/v3/species/common_names/loxodonta%20africana?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee 
    /// <summary>Common names a species holds</summary>
    public class CommonNames
    {
        [JsonProperty("taxonname")]
        public string TaxonName { get; set; }
        /// <summary> if true, then this is the main common name used for that species </summary>
        [JsonProperty("primary")]
        public bool Primary { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class CommonNamesRoot
    {
        /// <summary>Scientific name used for the search </summary>
        [JsonProperty("name")]
        public string ScientificName { get; set; }
        [JsonProperty("result")]
        public List<CommonNames> Result { get; set; }
    }
}
