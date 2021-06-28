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

<<<<<<< HEAD
            Filter filterProduct = new Filter(20); //Valor de ID que vai filtrar

            var product = new Product();

            List<IProducts> prodList = new List<IProducts>() 
=======
            var availableData = new List<IProduct>
>>>>>>> 3aaba1005b61a314c293d55e4a95cdabf105ff23
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
