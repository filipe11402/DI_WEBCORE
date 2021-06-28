using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Products.Domain.Models.Abstract;
using Products.Domain.Models;
using Products.API.Queries;
using Products.API.ViewModels;

namespace Products.APIControllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            var availableProducts = new ProductViewModel();

            var availableData = new List<IProduct>
            {
                new Product(1, "Shampoo"),
                new Product(2, "No more tears shampoo"),
                new Product(3, "Condoms"),
            };

            var query = new ProductQuery(availableData);

            availableProducts.Products = query.Filter();

            return View(availableProducts);
        }
    }
}
