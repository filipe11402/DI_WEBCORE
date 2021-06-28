using System.Collections.Generic;

namespace Products.API.Queries.Abstract
{
    public interface IFilterQuery<T>
    {
        IEnumerable<T> Filter();
    }
}
