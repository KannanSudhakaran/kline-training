using Lab04WebApiApp.Model;

namespace Lab04WebApiApp.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);

        void AddCustomer(Customer customer);
    }
}