using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Loppuprojekti_MVC.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult ResourcesIndex()
        {
            return View();
        }
    }
}