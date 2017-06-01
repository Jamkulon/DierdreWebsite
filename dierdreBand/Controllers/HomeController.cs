using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dierdreBand.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Shows()
        {
            ViewData["Message"] = "Your Shows Page.";

            return View();
        }

        public IActionResult Store()
        {
            ViewData["Message"] = "Your StorePage.";

            return View();
        }

        public IActionResult Musicians()
        {
            ViewData["Message"] = "Your MusicianPage.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
