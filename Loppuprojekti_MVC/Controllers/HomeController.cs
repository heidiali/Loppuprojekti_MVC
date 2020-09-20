using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Loppuprojekti_MVC.Models;

namespace Loppuprojekti_MVC.Controllers
{
    public class HomeController : Controller
    {

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

    }
}
