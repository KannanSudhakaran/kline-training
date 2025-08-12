using Lab04WebApiApp.Model;

namespace Lab04WebApiApp.Services
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> _customers = new List<Customer>()
            {
                new Customer() { Id = 1, FirstName = "John", LastName = "Doe" },
                new Customer() { Id = 2, FirstName = "Jane", LastName = "Smith" }
            };

        public CustomerService()
        {
            Console.WriteLine("customer service created");
        }
        public void AddCustomer(Customer customer)
        {
            customer.Id = _customers.Max(c => c.Id) + 1;
            _customers.Add(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customers;
        }

        public Customer GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
