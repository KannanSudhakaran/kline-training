using Lab02CustomerWebAPI.Domain;

namespace Lab02CustomerWebAPI.Repository
{
    public class CustomerInMemoryRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new List<Customer>();
        public CustomerInMemoryRepository() { 
        
            _customers.Add(new Customer { Id = 1,FullName = "Lin Hao" });

            _customers.Add(new Customer { Id = 2, FullName = "kannan sudhakaran" });
        }
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
           return _customers;
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
