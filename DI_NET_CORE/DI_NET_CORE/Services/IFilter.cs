using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_NET_CORE.Services
{
    public interface IFilter
    {

        public void FilterProducts(List<IProducts> prodList);

    }
}
