﻿using Microsoft.AspNetCore.Mvc;
using Msit147Site.Models;
using System.Diagnostics;

namespace Msit147Site.Controllers
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
            return View();
        }
        public IActionResult First()
        {
            return View();
        }

        public IActionResult Homework1() 
        {
            return View();
        }
        public IActionResult Homework2()
        {
            return View();
        }
        public IActionResult Homework3()
        {
            return View();
        }
        public IActionResult Homework4()
        {
            return View();
        }
        public IActionResult Address()
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