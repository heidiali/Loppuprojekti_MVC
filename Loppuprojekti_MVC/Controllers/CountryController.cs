using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loppuprojekti_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Threading;
using Microsoft.AspNetCore.Mvc.Localization;

namespace Loppuprojekti_MVC.Controllers
{
    public class CountryController : Controller
    {
        private CountryUtil ct = new CountryUtil();
        // GET: Countries
        public ActionResult CountryIndex(string firstLetter = "a")
        {
            CultureInfo cultureInfo = new CultureInfo("fi-FI");
            firstLetter = firstLetter.ToLower();
            List<CountryList> ctrs = ct.Countries().Where(t => t.Country.ToLower().StartsWith(firstLetter)).OrderBy(c => c.Country).ToList();

            ViewBag.Letters = string.Join("", ct.Countries().OrderBy(t => t.Country).Select(t => t.Country.Substring(0, 1)).Distinct());
            return View(ctrs);
        }

        // the parameter needed to use string interpolation in CountryUtil
        public ActionResult Country(string country) 
        {
            RegionInfo myRI = new RegionInfo(country);
            CountryUtil cu = new CountryUtil();
            IndividualSpecies ind = new IndividualSpecies();
            var countryspecies = cu.Country(country);
            //var endangeredSpecies = cu.Country(country).Where(c => c.Category == "EN");
            //var extinctSpecies = cu.Country(country).Where(c => c.Category == "EX");
            //var extinctWildSpecies = cu.Country(country).Where(c => c.Category == "EW");
            //var criticallyEndangeredSpecies = cu.Country(country).Where(c => c.Category == "CR");
            //var vulnerableSpecies = cu.Country(country).Where(c => c.Category == "VU");
            var allThreatenedSpecies = cu.Country(country).Where(c => c.Category == "EN" || c.Category == "EX" || c.Category == "EW"
            || c.Category == "CR" || c.Category == "VU");
            ViewBag.C = myRI.EnglishName; // Annukka is PROUD of this bit :)
            ViewBag.RI = myRI;
            ViewBag.Categories = string.Join("", ind.Category);
            RestUtil ru = new RestUtil();

            //foreach (var item in allThreatenedSpecies)
            //{
            //    //string name = ru.SingleSpecies(item.ScientificName).FirstOrDefault()?.MainCommonName;
            //    string name = ru.SingleSpecies(item.ScientificName).FirstOrDefault()?.MainCommonName;
            //    item.CommonName = name;
            //}

            return View(allThreatenedSpecies); // check what we actually want here!!
            //return View(countryspecies);

        }

        public ActionResult ENSpecies(string country)
        {
            RegionInfo myRI = new RegionInfo(country);
            CountryUtil cu = new CountryUtil();
            var endangeredSpecies = cu.Country(country).Where(c => c.Category == "EN");
            ViewBag.C = myRI.EnglishName;
            ViewBag.EN = endangeredSpecies;
            return View(endangeredSpecies);
        }

        public ActionResult EXSpecies(string country)
        {
            RegionInfo myRI = new RegionInfo(country);
            CountryUtil cu = new CountryUtil();
            var extinctSpecies = cu.Country(country).Where(c => c.Category == "EX");
            ViewBag.C = myRI.EnglishName;
            return View(extinctSpecies);
        }

        public ActionResult EWSpecies(string country)
        {
            RegionInfo myRI = new RegionInfo(country);
            CountryUtil cu = new CountryUtil();
            var extinctWildSpecies = cu.Country(country).Where(c => c.Category == "EW");
            ViewBag.C = myRI.EnglishName;
            return View(extinctWildSpecies);
        }

        public ActionResult CRSpecies(string country)
        {
            RegionInfo myRI = new RegionInfo(country);
            CountryUtil cu = new CountryUtil();
            var criticallyEndangeredSpecies = cu.Country(country).Where(c => c.Category == "CR");
            ViewBag.C = myRI.EnglishName;
            return View(criticallyEndangeredSpecies);
        }

        public ActionResult VUSpecies(string country)
        {
            RegionInfo myRI = new RegionInfo(country);
            CountryUtil cu = new CountryUtil();
            var vulnerableSpecies = cu.Country(country).Where(c => c.Category == "VU");
            ViewBag.C = myRI.EnglishName;
            return View(vulnerableSpecies);
        }

        //GET countries working version
        //public ActionResult CountryIndex(/*string firstLetter="a"*/)
        //{
        //    CountryUtil ct = new CountryUtil();
        //    //firstLetter = firstLetter.ToLower();
        //    //List<CountryList> countries = ct.Countries
        //    var countries = ct.Countries();
        //    return View(countries);
        //}


    }
}