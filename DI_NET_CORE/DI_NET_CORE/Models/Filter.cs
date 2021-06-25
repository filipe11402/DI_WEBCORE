using DI_NET_CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_NET_CORE.Models
{
    public class Filter: IFilter
    {

        public int Amount { get; set; }

        public Filter(int amount) 
        {
            Amount = amount;
        }

        public void FilterProducts(List<IProducts> prodlist) 
        {
            foreach (var product in prodlist.ToList()) 
            {
                if (product.Id > this.Amount)
                {
                    prodlist.Remove(product);
                }
            }
        }

    }
}
