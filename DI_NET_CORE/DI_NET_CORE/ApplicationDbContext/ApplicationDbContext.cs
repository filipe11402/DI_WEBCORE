using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Products.Domain.Models;

namespace Products.API.ApplicationDbContext
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        public DbSet<Product> PRoducts { get; set; }

    }
}
