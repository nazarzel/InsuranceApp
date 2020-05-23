using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InsuranceApp.Models;
using Microsoft.Extensions.Localization;

namespace InsuranceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> stringLocalizer;

        public HomeController(ILogger<HomeController> logger,
            IStringLocalizer<HomeController> stringLocalizer)
        {
            _logger = logger;
            this.stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            ViewBag.PageTitle = stringLocalizer["Language"];
            ViewData["Message"] = stringLocalizer["Language"];
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
