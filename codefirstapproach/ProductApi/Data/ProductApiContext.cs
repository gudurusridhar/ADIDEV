using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductApi.Model;

namespace ProductApi.Data
{
    public class ProductApiContext : DbContext
    {
        public ProductApiContext (DbContextOptions<ProductApiContext> options)
            : base(options)
        {
        }

        public DbSet<ProductApi.Model.Product> Product { get; set; } = default!;
        public DbSet<ProductApi.Model.Product> CatCategory { get; set; } = default!;

    }
}
