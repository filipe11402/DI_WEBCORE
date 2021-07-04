using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product_CQRS.Commands;
using Product_CQRS.Database;
using Product_CQRS.Models;
using Product_CQRS.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_CQRS.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _Mediator;
        private readonly ApplicationDbContext _ProductDb;
        private readonly IMapper _Mapper;

        public ProductController(IMediator mediator, ApplicationDbContext productDb, IMapper mapper)
        {
            _Mediator = mediator;
            _ProductDb = productDb;
            _Mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> productList = await _Mediator.Send(new ProductQueryModel());

            return View(productList);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePost(IEnumerable<Product> productsToBuy)
        {

            var getDiscounts = new ApplyDiscountProductCommand(productsToBuy, _ProductDb, _Mapper);
            await _Mediator.Send(getDiscounts);

            return RedirectToAction("Index");
        }
    }
}
