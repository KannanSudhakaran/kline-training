using Lab02CustomerWebAPI.Domain;

namespace Lab02CustomerWebAPI.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        void AddCustomer(Customer customer);
    }
}
