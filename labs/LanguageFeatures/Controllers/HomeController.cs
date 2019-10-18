using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }
        public ViewResult Index()
        {
            var products = new[] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };

            return View(products.Select(p => p.Name));
            //Func<Product, bool> nameFilter = delegate (Product prod) {
            //    return prod?.Name?[0] == 'S';
            //};
            //decimal priceFilterTotal = productArray
            //    .Filter(p => (p?.Price ?? 0) >= 20)
            //    .TotalPrices();
            //decimal nameFilterTotal = productArray
            //    .Filter(p => p?.Name?[0] == 'S')
            //    .TotalPrices();

            //return View(Product.GetProducts().Select(p => p?.Name));

            //return View("Index", new string[] {
            //    $"Price Total: {priceFilterTotal:C2}",
            //    $"Name Total: {nameFilterTotal:C2}" });
        }

    }
}    

