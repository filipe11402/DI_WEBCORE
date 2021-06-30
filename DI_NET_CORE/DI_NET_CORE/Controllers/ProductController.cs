using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Products.Domain.Models.Abstract;
using Products.Domain.Models;
using Products.API.Queries;
using Products.API.ViewModels;
using Products.API.ExtensionMethods;
using Products.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Products.APIControllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db) 
        {
            _db = db;

            //creating dummy data
            /*List<IProduct> availableData = new List<IProduct>()
            {
                new Product() { Name="Teste", Description="teste desciption", Price=10},
                new Product() { Name="teste 2", Description="teste de description 2", Price=20},
            };

            foreach (var product in availableData) 
            {
                _db.Add(product);
                _db.SaveChanges();
            }*/
        }


        public IActionResult Index()
        {
            var availableProducts = new ProductViewModel();


            //Filter filterProduct = new Filter(20); //Valor de ID que vai filtrar

            //var product = new Product();

            //List<IProducts> prodList = new List<IProducts>();

            availableProducts.Products = _db.Products;

            return View(availableProducts);
        }
        
        //POST method
        [HttpPost]
        public IActionResult UpdatePost(IEnumerable<Product> toBeUpdatedList)
        {

            ProductViewModel updatedProductList = new ProductViewModel();


            updatedProductList.Products = toBeUpdatedList.Filter();

            if (ModelState.IsValid) 
            {
                foreach (var filteredProduct in updatedProductList.Products) 
                {
                    _db.Entry(filteredProduct).State = EntityState.Modified;
                }
                _db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }

        //GET method
        public IActionResult Create() 
        {
            return View();
        }

        //POST method
        [HttpPost]
        public IActionResult CreatePost(Product newProduct) 
        {
            //check if user has inputed anything containing catnip
        }

    }
}
