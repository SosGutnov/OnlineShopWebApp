using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class StartController : Controller
    {
        private readonly ILogger<StartController> _logger;

        public StartController(ILogger<StartController> logger)
        {
            _logger = logger;
        }

        public string Hello()
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            string res = "";
            if (hours >= 0 && hours < 6) res = "Доброй ночи";
            else if (hours >= 6 && hours < 12) res = "Доброе утро";
            else if (hours >= 12 && hours < 18) res = "Добрый день";
            else res = "Добрый вечер";
            return res;
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
