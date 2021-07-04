using MediatR;
using Product_CQRS.Database;
using Product_CQRS.Models;
using Product_CQRS.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Product_CQRS.Handlers
{
    public class GetProductListHandler : IRequestHandler<ProductQueryModel, IEnumerable<Product>>
    {

        private readonly IApplicationDbContext _ProductDb;

        public GetProductListHandler(IApplicationDbContext dbContext) 
        {
            _ProductDb = dbContext;
        }

        public async Task<IEnumerable<Product>> Handle(ProductQueryModel request, CancellationToken cancellationToken)
        {
            IEnumerable<Product> productList = _ProductDb.Products;

            return await Task.FromResult(productList);
        }
    }
}
