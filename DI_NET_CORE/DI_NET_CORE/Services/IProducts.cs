using DI_NET_CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_NET_CORE.Services
{
    public interface IProducts
    {

        public int Id { get; set; }
        public string productName { get; set; }


        public void FilterProducts(List<IProducts> prodlist, IFilter filter);
    }
}
