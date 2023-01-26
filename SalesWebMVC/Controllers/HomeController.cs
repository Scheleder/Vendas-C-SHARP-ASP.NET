using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sales Web MVC Application - ASP.NET on C#";
            ViewData["Developer"] = "João Scheleder Neto";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Email"] = "me@scheleder.com";
            ViewData["Name"] = "João Scheleder Neto";
            ViewData["website"] = "https//www.scheleder.com";
            ViewData["Phone"] = "+55 41 991 248 571";

            return View();
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
