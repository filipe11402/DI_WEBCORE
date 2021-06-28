using Products.Domain.Models.Abstract;
using System.Collections.Generic;

namespace Products.API.ViewModels
{
    public class ProductViewModel
    {

        public IEnumerable<IProduct> Products;
    }
}
