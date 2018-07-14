using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestBookNinjectApp.Models
{
    public class ShopingCart
    {
        private IValueCalculator calc;
        public ShopingCart(IValueCalculator valueCalculator)
        {
            calc = valueCalculator;
        }
        public IEnumerable<Product> Products { get; set; }
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}