using MediatR;
using Product_CQRS.Commands;
using Product_CQRS.Database;
using Product_CQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Product_CQRS.Handlers
{
    public class ApplyProductDiscountHandler : IRequestHandler<ApplyDiscountProductCommand, IEnumerable<Product>>
    {


        public async Task<IEnumerable<Product>> Handle(ApplyDiscountProductCommand request, CancellationToken cancellationToken)
        {
            request.ApplyDiscounts();

            return await Task.FromResult(request.ProductList);
        }
    }
}
