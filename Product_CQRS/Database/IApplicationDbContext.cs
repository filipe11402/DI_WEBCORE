using Microsoft.EntityFrameworkCore;
using Product_CQRS.Models;

namespace Product_CQRS.Database
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
    }
}