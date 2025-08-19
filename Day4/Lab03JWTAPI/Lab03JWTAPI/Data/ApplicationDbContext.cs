using Lab03JWTAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lab03JWTAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Employee> Employees { get; set; }

    }
}
