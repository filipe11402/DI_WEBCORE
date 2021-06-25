using DI_NET_CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_NET_CORE.Models
{
    public class Product: IProducts
    {

        public IFilter Filter;

        public List<IProducts> prodList;

        public int Id { get; set; }
        public string productName { get; set; }


        //recebe um objeto de Interface
        public void FilterProducts(List<IProducts> prodlist, IFilter filter) 
        {
            prodList = prodlist;
            Filter = filter;
            Filter.FilterProducts(prodList);
        }
    }
}
