using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Domain;


namespace ShoppingApp.EFRepositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CatalogType> CatalogTypes { get; set; } = default!;
        public DbSet<CatalogBrand> CatalogBrands { get; set; } = default!;
        public DbSet<CatalogItem> CatalogItems { get; set; } = default!;
    }
}
