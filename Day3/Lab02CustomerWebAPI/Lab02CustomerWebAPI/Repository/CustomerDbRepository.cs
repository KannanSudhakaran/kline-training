using Lab02CustomerWebAPI.Data;
using Lab02CustomerWebAPI.Domain;

namespace Lab02CustomerWebAPI.Repository
{
    public class CustomerDbRepository : ICustomerRepository
    {
        private readonly KlineAppDbContext _context;
        public CustomerDbRepository(KlineAppDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(Customer customer)
        {
           _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
