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
    public class GetOrderListHandler : IRequestHandler<OrderQueryModel, IEnumerable<Order>>
    {
        private readonly IApplicationDbContext _ProductDb;

        public GetOrderListHandler(IApplicationDbContext productDb)
        {
            _ProductDb = productDb;
        }
        public async Task<IEnumerable<Order>> Handle(OrderQueryModel request, CancellationToken cancellationToken)
        {
            IEnumerable<Order> orderList = _ProductDb.Orders;

            return await Task.FromResult(orderList);
        }
    }
}
