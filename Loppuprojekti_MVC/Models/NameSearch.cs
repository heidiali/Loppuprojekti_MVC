using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Loppuprojekti_MVC.Models
{
    //this class is not used
    public class NameSearch
    {
        public int Taxonid { get; set; }
        public string MainCommonName { get; set; }
        public string ScientificName { get; set; }
        public string Category { get; set; }
        public string PopulationTrend { get; set; }

        public SelectList ScientificNames;
    }
}
