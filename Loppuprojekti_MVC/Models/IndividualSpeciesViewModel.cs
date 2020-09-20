using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loppuprojekti_MVC.Models
{
    public class IndividualSpeciesViewModel
    {
        public IndividualSpecies Species { get; set; }
        public SpeciesNarrative Narrative { get; set; }
        public Link Link { get; set; }
    }
}
