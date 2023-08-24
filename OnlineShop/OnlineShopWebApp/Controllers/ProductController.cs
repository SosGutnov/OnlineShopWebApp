using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductData productData = new ProductData();

        public string Index(int id)
        {
            var products = productData.GetAllProducts();
            foreach (var product in products)
            {
                if (product.Id==id)
                {
                    return product.ToString();
                }
            }
            return "Не найден";
        }
    }
}
