using Products.API.Queries.Abstract;
using Products.Domain.Models.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Products.API.Queries
{
    public class ProductQuery : IFilterQuery<IProduct>
    {
        readonly IEnumerable<IProduct> _availableProducts;

        public ProductQuery(IEnumerable<IProduct> availableProducts)
        {
            this._availableProducts = availableProducts;
        }

        public IEnumerable<IProduct> Filter()
        {
            return this._availableProducts.Where(product => product.Id > 1);
        }
    }
}
