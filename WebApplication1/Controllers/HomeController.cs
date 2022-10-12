using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    // : Controller ile extends ediyoruz!
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string data = "Hello From Controller Data";
            ViewBag.Message = data;
            return View("Index");
        }

        public IActionResult Privacy(){
            ViewResult result=View();
            return result;
        }

        public IActionResult Contact()
        {
            int number = 25;
            return View(number);
        }

        public IActionResult browse()
        {
            return View();
        }

        public IActionResult details()
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