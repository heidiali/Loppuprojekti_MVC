using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loppuprojekti_MVC.Models
{
    /// <summary>
    /// Retuns link to IUCN page
    /// </summary>
    public class Link
    {
        [JsonProperty("rlurl")]
        public string Rlurl { get; set; }
        [JsonProperty("species")]
        public string ScientificName { get; set; }
    }
}
