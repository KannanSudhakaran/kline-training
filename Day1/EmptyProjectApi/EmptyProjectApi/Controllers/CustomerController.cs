using Microsoft.AspNetCore.Mvc;

namespace EmptyProjectApi.Controllers
{
    [Route("api/v1/[controller]")]
    public class CustomerController:ControllerBase
    {
        [HttpGet]
        public IActionResult GetCustomers()
        {
            // Simulate fetching customers from a database or service
            var customers = new[]
            {
                new { Id = 1, Name = "John Doe" },
                new { Id = 2, Name = "Jane Smith" }
            };
            return Ok(customers);
        }
        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            // Simulate fetching a customer by ID
            var customer = new { Id = id, Name = "Sample Customer" };
            return Ok(customer);
        }
    }
}
