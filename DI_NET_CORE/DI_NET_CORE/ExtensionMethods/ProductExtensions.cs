using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Products.API.Queries.Abstract;
using Products.Domain.Models;
using Products.Domain.Models.Abstract;


namespace Products.API.ExtensionMethods
{
    public static class ProductExtensions
    {

        public static IEnumerable<Product> Filter(this IEnumerable<Product> myProducts) 
        {
            //Filtering myProducts when Id less than 2
            return myProducts.Where(x => x.Description.Contains("catnip"));
        }

    }
}
