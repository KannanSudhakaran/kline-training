using Lab02CustomerWebAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02CustomerWebAPI.Data
{
    public class KlineAppDbContext:DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        //will do dependency injection for the DbContextOptions
        public KlineAppDbContext(DbContextOptions<KlineAppDbContext> options) : base(options)
        {
        }

    }
}
