using Lab02CustomerWebAPI.Data;
using Lab02CustomerWebAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lab02CustomerWebAPI.Repository
{
    public class CustomerDbRepository : ICustomerRepository
    {
        private readonly KlineAppDbContext _dbContext;
        public CustomerDbRepository(KlineAppDbContext context)
        {
            _dbContext = context;
        }
        public void AddCustomer(Customer customer)
        {
           _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
           _dbContext.Customers.Remove(GetCustomerById(id));
           _dbContext.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {

            return _dbContext.Customers.FirstOrDefault(c => c.Id == id); ;
        }

        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public void UpdateCustomer(Customer newCustomer)
        {
           _dbContext.Entry(newCustomer).State = EntityState.Modified;
           _dbContext.SaveChanges();
        }
    }
}
