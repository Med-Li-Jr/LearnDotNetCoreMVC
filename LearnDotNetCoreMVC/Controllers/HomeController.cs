using LearnDotNetCoreMVC.Models;
using LearnDotNetCoreMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToRoute("registerForm");
        }


        [HttpGet("/register", Name = "registerForm")]
        public IActionResult Register()
        {
            return View("../Auths/Register");
        }


        [HttpGet("/demands", Name = "dashboardDemand")]
        public IActionResult IndexDemand()
        {
            string messageError = null;
            string HasError = "null";

            List<Demande> AllDemands = new List<Demande>();

            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Demandes";

            return View("../Demands/Index", AllDemands);
        }


        [HttpGet("/organizations", Name = "dashboardOrganization")]
        public IActionResult IndexOrganization()
        {

            string messageError = null;
            string HasError = "null";

            List<Organization> AllOrganization = new List<Organization>();

            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Organisations";

            return View("../Organizations/Index",AllOrganization);
        }

















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
