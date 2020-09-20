using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loppuprojekti_MVC.Models
{
    public partial class SpeciesCommonName
    {
        [JsonProperty("taxon_id")]
        public int Taxonid { get; set; }
        [Display(Name = "Scientific Name")]
        [JsonProperty("scientific_name")]
        public string ScientificName { get; set; }
        [JsonProperty("kingdom")]
        public string KingdomName { get; set; }
        [JsonProperty("phylum")]
        public string PhylumName { get; set; }
        [JsonProperty("class")]
        public string ClassName { get; set; }
        [JsonProperty("order")]
        public string OrderName { get; set; }
        [JsonProperty("family")]
        public string FamilyName { get; set; }
        [JsonProperty("genus")]
        public string GenusName { get; set; }
        /// <summary> Primary name by which the species has been tagged in the Red List </summary>
        [Display(Name = "Common Name")]
        [JsonProperty("main_common_name")]
        public string MainCommonName { get; set; }
        [JsonProperty("authority")]
        public string Authority { get; set; }
        [JsonProperty("published_year")]
        public int PublishedYear { get; set; }
        [JsonProperty("assessment_date")]
        public string AssessmentDate { get; set; }
        /// <summary> The Red List Category: CR-cirtically endangered, EN-Endangered, CO-collapsed, NT-Near threatened, VU-vulnerable, DD-Data Deficient, LC-Least concerned, NE-not evaluated, </summary>
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("criteria")]
        public string Criteria { get; set; }
        [Display(Name = "Population trend")]
        [JsonProperty("population_trend")]
        public string PopulationTrend { get; set; }
        /// <summary> True is the species is marine </summary>
        [Display(Name = "Marine system")]
        [JsonProperty("marine_system")]
        public bool MarineSystem { get; set; }
        /// <summary> True is the species is fresh water </summary>
        [Display(Name = "Freshwater system")]
        [JsonProperty("freshwater_system")]
        public bool FreshwaterSystem { get; set; }
        /// <summary> True is the species is terrestrial </summary>
        [Display(Name = "Terrestrial system")]
        [JsonProperty("terrestrial_system")]
        public bool TerrestrialSystem { get; set; }
        [JsonProperty("assessor")]
        public string Assessor { get; set; } //Assessors who carried out the assessment
        [JsonProperty("reviewer")]
        public string Reviewer { get; set; }
        [JsonProperty("aoo_km2")]
        public object AooKm2 { get; set; } //Area of occupancy
        [JsonProperty("eoo_km2")]
        public object EooKm2 { get; set; } //extent of occurance
        [JsonProperty("elevation_upper")]
        public object ElevationUpper { get; set; }
        [JsonProperty("elevation_lower")]
        public object ElevationLower { get; set; }
        [JsonProperty("depth_upper")]
        public object DepthUpper { get; set; }
        [JsonProperty("depth_lower")]
        public object DepthLower { get; set; }
        [JsonProperty("errata_flag")]
        public object ErrataFlag { get; set; } //true if the assessment is an errata (error) assessment
        [JsonProperty("errata_reason")]
        public object ErrataReason { get; set; } //The reason for the errata (error) change, if applicable
        [JsonProperty("amended_flag")]
        public object AmendedFlag { get; set; } //true if the assessment is an errata (error) assessment
        [JsonProperty("amended_reason")]
        public object AmendedReason { get; set; } //The reason for the amended change, if applicable

    }

    //We chose to have nice C# names, thus JSOn serializer cannot recognize them (they are not precisely the same) and they are defined with [JsonProperty("")].

    //Ti: changed into partial classes from classes, to get partial view to function
    
    /// <summary> Red List Individual Species by name </summary>
    public partial class IndividualSpecies
    {
        [JsonProperty("taxon_id")]
        public int Taxonid { get; set; }
        [Display(Name = "Scientific Name")]
        [JsonProperty("scientific_name")]
        public string ScientificName { get; set; }
        [JsonProperty("kingdom")]
        public string KingdomName { get; set; }
        [JsonProperty("phylum")]
        public string PhylumName { get; set; }
        [JsonProperty("class")]
        public string ClassName { get; set; }
        [JsonProperty("order")]
        public string OrderName { get; set; }
        [JsonProperty("family")]
        public string FamilyName { get; set; }
        [JsonProperty("genus")]
        public string GenusName { get; set; }
        /// <summary> Primary name by which the species has been tagged in the Red List </summary>
        [JsonProperty("main_common_name")]
        public string MainCommonName { get; set; }
        [JsonProperty("authority")]
        public string Authority { get; set; }
        [JsonProperty("published_year")]
        public int PublishedYear { get; set; }
        [JsonProperty("assessment_date")]
        public string AssessmentDate { get; set; }
        /// <summary> The Red List Category: CR-cirtically endangered, EN-Endangered, CO-collapsed, NT-Near threatened, VU-vulnerable, DD-Data Deficient, LC-Least concerned, NE-not evaluated, </summary>
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("criteria")]
        public string Criteria { get; set; }
        [JsonProperty("population_trend")]
        public string PopulationTrend { get; set; }
        /// <summary> True is the species is marine </summary>
        [JsonProperty("marine_system")]
        public bool MarineSystem { get; set; }
        /// <summary> True is the species is fresh water </summary>
        [JsonProperty("freshwater_system")]
        public bool FreshwaterSystem { get; set; }
        /// <summary> True is the species is terrestrial </summary>
        [JsonProperty("terrestrial_system")]
        public bool TerrestrialSystem { get; set; }
        [JsonProperty("assessor")]
        public string Assessor { get; set; } //Assessors who carried out the assessment
        [JsonProperty("reviewer")]
        public string Reviewer { get; set; }
        [JsonProperty("aoo_km2")]
        public object AooKm2 { get; set; } //Area of occupancy
        [JsonProperty("eoo_km2")]
        public object EooKm2 { get; set; } //extent of occurance
        [JsonProperty("elevation_upper")]
        public object ElevationUpper { get; set; }
        [JsonProperty("elevation_lower")]
        public object ElevationLower { get; set; }
        [JsonProperty("depth_upper")]
        public object DepthUpper { get; set; }
        [JsonProperty("depth_lower")]
        public object DepthLower { get; set; }
        [JsonProperty("errata_flag")]
        public object ErrataFlag { get; set; } //true if the assessment is an errata (error) assessment
        [JsonProperty("errata_reason")]
        public object ErrataReason { get; set; } //The reason for the errata (error) change, if applicable
        [JsonProperty("amended_flag")]
        public object AmendedFlag { get; set; } //true if the assessment is an errata (error) assessment
        [JsonProperty("amended_reason")]
        public object AmendedReason { get; set; } //The reason for the amended change, if applicable

    }

    /// <summary>The IndividualSpeciesRoot property represents the JSON Objects the GET returns.</summary>
    public partial class IndividualSpeciesRoot
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("result")]
        public List<IndividualSpecies> Result { get; set; }
    }
}
