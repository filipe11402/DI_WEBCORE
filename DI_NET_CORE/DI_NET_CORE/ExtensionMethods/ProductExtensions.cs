using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Products.API.Queries.Abstract;
using Products.Domain.Models.Abstract;


namespace Products.API.ExtensionMethods
{
    public static class ProductExtensions
    {

        public static List<IProduct> Filter(this List<IProduct> myProducts) 
        {
            //Filtering myProducts when Id less than 2
            foreach (var Product in myProducts.ToList())
            {
                if (Product.Id < 2) 
                {
                    myProducts.Remove(Product);
                }
            }

            return myProducts;
        }

    }
}
