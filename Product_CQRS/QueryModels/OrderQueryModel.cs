using MediatR;
using Product_CQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_CQRS.QueryModels
{
    public class OrderQueryModel: IRequest<IEnumerable<Order>>
    {
    }
}
