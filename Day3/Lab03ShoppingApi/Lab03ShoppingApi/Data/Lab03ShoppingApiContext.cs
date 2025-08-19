using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab03ShoppingApi.Domain;

namespace Lab03ShoppingApi.Data
{
    public class Lab03ShoppingApiContext : DbContext
    {
        public Lab03ShoppingApiContext (DbContextOptions<Lab03ShoppingApiContext> options)
            : base(options)
        {
        }

        public DbSet<Lab03ShoppingApi.Domain.CatalogType> CatalogType { get; set; } = default!;
        public DbSet<Lab03ShoppingApi.Domain.CatalogBrand> CatalogBrand { get; set; } = default!;
        public DbSet<Lab03ShoppingApi.Domain.CatalogItem> CatalogItem { get; set; } = default!;
    }
}
