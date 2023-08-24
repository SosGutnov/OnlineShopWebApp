using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int a, int b, string op)
        {
            string res = "";
            if (op == "-")
            {
                res = a.ToString() + " " + op + " " + b.ToString() + " = " + (a - b).ToString();
            }
            else if (op == "*")
            {
                res = a.ToString() + " " + op + " " + b.ToString() + " = " + (a * b).ToString();
            }
            else
            {
                res = a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
            }
            return res;
        }
    }
}
