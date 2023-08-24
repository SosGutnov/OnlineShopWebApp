using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp
{
    public class ProductData
    {
        private static List<Product> products = new List<Product>()
        {
            new Product(0, "Game 1", 100, "Игра 1"),
            new Product(1, "Game 2", 1500, "Игра 2"),
            new Product(2, "Game 3", 120, "Игра 3"),
            new Product(3, "Game 4", 110, "Игра 4"),
        };

        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
