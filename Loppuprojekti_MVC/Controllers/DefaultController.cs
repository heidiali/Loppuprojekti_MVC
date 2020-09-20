using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Loppuprojekti_MVC.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int ID=1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;
            return View();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}