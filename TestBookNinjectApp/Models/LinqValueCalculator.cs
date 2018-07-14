using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestBookNinjectApp.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discount;

        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discount = discountParam;
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discount.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}