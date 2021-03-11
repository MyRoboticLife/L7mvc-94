/////////////////////////////////////////////////////////////////////////////
///Date     Developer       Comments
///3-2-21   Javier Esparza  Started creating program following chucks vids
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Controllers
{
    //accepts the request from user, then follows routing conventions, then decides what to do
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //views has a folder for each message under privacy
        public IActionResult Privacy(string first, string last, string email)
        {
            ViewData["FirstName"] = first;
            ViewData["LastName"] = last;
            ViewData["EmailAddress"] = email;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
