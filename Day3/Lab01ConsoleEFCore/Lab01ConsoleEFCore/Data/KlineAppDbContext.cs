using Lab01ConsoleEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01ConsoleEFCore.Data
{
    public class KlineAppDbContext:DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=klinedb1;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }

    }
}
