using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Loppuprojekti_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace Loppuprojekti_MVC.Controllers
{
    //TODO: Initialize RestUtil in field, then just call it in all the methods

     //only search logic, GET logic in Models.RestUtil 
    public class SpeciesController : Controller
    {
        private RestUtil _rs = new RestUtil();
        //PartialView
        IndividualSpeciesViewModel vm = new IndividualSpeciesViewModel();

        // GET species, /Species
        public ActionResult SpeciesIndex(string searchTerms) 
        {
            var _species = _rs.Species();

            if (string.IsNullOrEmpty(searchTerms))
            {
                return View(_species);
            }
            else
            {
                return RedirectToAction("SCategory", "Species", new { @searchTerms = searchTerms });
            }

        }

        // GET individual info for individual species, /Species/SingleSpecies
        public ActionResult SingleSpecies(string searchTerms)
        {
            var _as = _rs.SingleSpecies(searchTerms);

            //PartialView
            vm.Species = _as.FirstOrDefault(); 
            vm.Narrative = _rs.SingleNarrative(searchTerms).FirstOrDefault();
            vm.Link = _rs.IUCNurl(searchTerms);

            return View(vm);
            //return View(_as[0]); //ennen partialView:tä
            //return View(_as.FirstOrDefault());
        }

        // GET individual info for individual species, /Species/SingleSpecies
        public ActionResult SingleNarrative(string searchTerms)
        {
            var _as = _rs.SingleNarrative(searchTerms);
            return View(_as[0]);
        }

        // GET IUCN page for individual species
        public ActionResult IUCNurl(string searchTerms)
        {
            var _ls = _rs.IUCNurl(searchTerms);

            //ViewBag.Link = _as;
            return View(_ls.Rlurl);
            //return ViewBag(_ls.Rlurl);
        }

        // GET IUCN for count of species in different vulnerability classes
        //searchTerm: vulnerability class
        public ActionResult SCategory(string searchTerms)
        {
            IndividualSpecies ind = new IndividualSpecies();
            ViewBag.SC = ind.Category;
            var _sc = _rs.SCategory(searchTerms);
            return View(_sc);
        }

    }
}