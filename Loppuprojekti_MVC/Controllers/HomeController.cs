using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Loppuprojekti_MVC.Models;
using Microsoft.AspNetCore.Mvc.Localization;

namespace Loppuprojekti_MVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IHtmlLocalizer<HomeController> _localizer;

        //public HomeController(HtmlLocalizer<HomeController> localizer)
        //{
        //    _localizer = localizer;
        //}

        public IActionResult Index(string searchTerms)
        {
            if (string.IsNullOrEmpty(searchTerms))
            {
                return View();
            }
            else
            {
                return RedirectToAction("SingleSpecies", "Species", new { @searchTerms = searchTerms }); 
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //TODO: remove, unused
        //[HttpGet]
        //public ActionResult NSearch(NameSearch searchTerms)
        //{
        //    if (string.IsNullOrEmpty(searchTerms.ScientificName))
        //    {
        //        ModelState.AddModelError("", "Please search with a name.");
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return RedirectToAction("SingleSpecies","Species");
        //    }

        //}
    }
}
