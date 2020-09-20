using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Loppuprojekti_MVC.Controllers.Maps
{
    public class BubbleController : Controller
    {
        public IActionResult Bubble()
        {
            //ViewBag.mapdata = GetWorldMap();
            return View();
        }
    }
}