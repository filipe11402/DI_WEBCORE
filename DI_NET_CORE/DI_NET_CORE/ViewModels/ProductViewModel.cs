using Products.Domain.Models.Abstract;
using System.Collections.Generic;
using Products.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Products.API.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products;
    }
}
