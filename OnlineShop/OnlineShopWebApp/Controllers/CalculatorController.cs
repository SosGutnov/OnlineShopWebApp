using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int a, int b)
        {
            return a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
        }
    }
}
