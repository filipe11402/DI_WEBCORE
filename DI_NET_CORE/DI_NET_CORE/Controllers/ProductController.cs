using DI_NET_CORE.Models;
using DI_NET_CORE.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_NET_CORE.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            Filter filterProduct = new Filter(20); //Valor de ID que vai filtrar

            var product = new Product();

            List<IProducts> prodList = new List<IProducts>() 
            {
                new Product() { Id=2, productName="canetas"},
                new Product() { Id=10, productName="lapis"},
            };

            product.FilterProducts(prodList, filterProduct);

            
            
            return View(prodList);
        }
    }
}
