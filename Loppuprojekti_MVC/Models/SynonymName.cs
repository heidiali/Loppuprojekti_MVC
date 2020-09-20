using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loppuprojekti_MVC.Models
{
    //http://apiv3.iucnredlist.org/api/v3/species/synonym/loxodonta%20africana?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee
    public class SynonymName
    {
        [JsonProperty("accepted_id")]
        public int Species_id { get; set; }
        [JsonProperty("accepted_name")]
        public string ScientificName { get; set; }
        [JsonProperty("authority")]
        public string Authority { get; set; }
        /// <summary>Synonyms are alternative Scientific names</summary>
        [JsonProperty("synonym")]
        public string Synonym { get; set; }
        [JsonProperty("syn_authority")]
        public string SynAuthority { get; set; }
    }

    /// <summary>List returns many items</summary>
    public class SynonymNameRoot
    {
        [JsonProperty("name")]
        public string ScientificName { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; } //count of results returned
        [JsonProperty("result")]
        public List<SynonymName> Result { get; set; }
    }
}
