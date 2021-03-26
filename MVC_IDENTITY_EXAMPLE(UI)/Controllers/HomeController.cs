using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_IDENTITY_EXAMPLE_UI_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Service.Interfaces;
using BLL.Service;

namespace MVC_IDENTITY_EXAMPLE_UI_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarService _carService;
  

        public HomeController(ILogger<HomeController> logger, CarService carService)
        {
            _carService = carService;
            _logger = logger;

        }
        [HttpGet]
        public IActionResult Index()
        {

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
