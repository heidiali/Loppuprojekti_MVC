using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loppuprojekti_MVC.Models
{
    //tester for narrative partial View
    public partial class Narrative
    {
        //We chose to have nice C# names, thus JSOn serializer cannot recognize them (they are not precisely the same) and they are defined with [JsonProperty("")].

        [JsonProperty("species_id")]
        public int Species_id { get; set; }

        [JsonProperty("taxonomicnotes")]
        [Display(Name = "Taxonomic notes")]
        public string Taxonomicnotes { get; set; }

        [JsonProperty("rationale")]
        public string Rationale { get; set; }

        [Display(Name = "Geographic range")]
        [JsonProperty("geographicrange")]
        public string Geographicrange { get; set; }

        [JsonProperty("population")]
        public string Population { get; set; }

        [Display(Name = "Population trend")]
        [JsonProperty("populationtrend")]
        public string Populationtrend { get; set; }
        [JsonProperty("habitat")]
        public string Habitat { get; set; }
        [JsonProperty("threats")]
        public string Threats { get; set; }
        [Display(Name = "Conservation Measures")]
        [JsonProperty("conservationmeasures")]
        public string ConservationMeasures { get; set; }
        [JsonProperty("usetrade")]
        public object Usetrade { get; set; }
    }

    public partial class NarrativeRoot
    {
        [Display(Name = "Scientific Name")]
        [JsonProperty("name")]
        public string ScientificName { get; set; }
        [JsonProperty("result")]
        public List<Narrative> Result { get; set; }
    }
}
