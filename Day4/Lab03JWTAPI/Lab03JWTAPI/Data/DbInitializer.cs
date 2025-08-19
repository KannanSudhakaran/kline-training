using Lab03JWTAPI.Domain;
using System;

namespace Lab03JWTAPI.Data
{
    public class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.AppUsers.Any())
            {
                context.AppUsers.AddRange(
                    new AppUser { Username = "admin", PasswordHash = "admin", Role = "admin" },
                    new AppUser { Username = "user", PasswordHash = "user", Role = "normal" }
                );
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee { Name = "Alice Johnson", Position = "Software Engineer" },
                    new Employee { Name = "Bob Smith", Position = "Product Manager" },
                    new Employee { Name = "Carol Williams", Position = "QA Analyst" }
                );
            }

            context.SaveChanges();
        }
    }

}

