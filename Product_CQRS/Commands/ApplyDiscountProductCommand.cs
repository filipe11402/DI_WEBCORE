using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Product_CQRS.Database;
using Product_CQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_CQRS.Commands
{
    public class ApplyDiscountProductCommand: IRequest<IEnumerable<Product>>
    {

        public IEnumerable<Product> ProductList;
        private readonly ApplicationDbContext _ProductDb;
        private readonly IMapper _Mapper;

        public ApplyDiscountProductCommand(IEnumerable<Product> productList, ApplicationDbContext productDb, IMapper mapper)
        {
            ProductList = productList;
            _ProductDb = productDb;
            _Mapper = mapper;
        }

        public IEnumerable<Product> ApplyDiscounts() 
        {
            IEnumerable<Order> orderList = _Mapper.Map<IEnumerable<Product>, IEnumerable<Order>>(ProductList);

            foreach (var productOrdered in orderList) 
            {
                productOrdered.ProductPrice -= 2;
                _ProductDb.Add(productOrdered);
                _ProductDb.SaveChanges();
            }

            
            

            return ProductList;
        }

    }
}
