using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestBookNinjectApp.Models;

namespace TestBookNinjectApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private Product[] products =
        {
            new Product { Name = "Kayak", Category = "Watersports", Price = 275M },
            new Product { Name = "Lifejacket", Category = "Watersports", Price = 48.95M },
            new Product { Name = "Corner flag", Category = "Soccer", Price = 34.95M },
            new Product { Name = "Soccer ball", Category = "Soccer", Price = 19.50M }
        };
        private IValueCalculator calculator;

        public HomeController(IValueCalculator valueCalculator)
        {
            calculator = valueCalculator;
        }

        public ActionResult Index()
        {
            ShopingCart cart = new ShopingCart(calculator) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}