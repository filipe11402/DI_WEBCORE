using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Products.Domain.Models.Abstract;
using Products.Domain.Models;
using Products.API.Queries;
using Products.API.ViewModels;
using Products.API.ExtensionMethods;

namespace Products.APIControllers
{
    public class ProductController : Controller
    {


        public IActionResult Index()
        {
            var availableProducts = new ProductViewModel();


            //Filter filterProduct = new Filter(20); //Valor de ID que vai filtrar

            //var product = new Product();

            //List<IProducts> prodList = new List<IProducts>();



            //availableProducts.Products = availableData;

            return View(availableProducts);
        }
    }
}
