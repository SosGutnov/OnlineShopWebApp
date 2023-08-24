using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a, double b, string c)
        {
            string res = "";
            if (c == "-")
            {
                res = a.ToString() + " " + c + " " + b.ToString() + " = " + (a - b).ToString();
            }
            else if (c == "*")
            {
                res = a.ToString() + " " + c + " " + b.ToString() + " = " + (a * b).ToString();
            }
            else if (c == "/")
            {
                res = a.ToString() + " " + c + " " + b.ToString() + " = " + (a / b).ToString();
            }
            else
            {
                res = a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
            }
            return res;
        }
    }
}
