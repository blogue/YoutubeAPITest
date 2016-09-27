using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YoutubeAPITest.Models;

namespace YoutubeAPITest.Controllers
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

        public IActionResult Error()
        {
            return View();
        }
        public async Task<IActionResult> SearchVideos(string searchTerm)
        {
            Search newSearch = new Search();
            var result = await newSearch.Run(searchTerm);
            return View(result);
        }
    }
}
