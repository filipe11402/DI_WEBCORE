using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product_CQRS.Models;
using Product_CQRS.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_CQRS.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMediator _Mediator;

        public OrderController(IMediator mediator)
        {
            _Mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {

            IEnumerable<Order> orderList = await _Mediator.Send(new OrderQueryModel());

            return View(orderList);
        }
    }
}
