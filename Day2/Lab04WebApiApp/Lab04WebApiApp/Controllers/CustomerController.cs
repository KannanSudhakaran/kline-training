using Lab04WebApiApp.Model;
using Lab04WebApiApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Lab04WebApiApp.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController:ControllerBase
    {
        private readonly ICustomerService _customerService;//has a relationship

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("all")]
        public IActionResult GetAllCustomers() { 

            return Ok(_customerService.GetAllCustomers());
        }

        [HttpGet("{customerId:int}")]
        public IActionResult GetCustomerByid(int customerId) {

            var customer = _customerService.GetCustomerById(customerId);
            if (customer == null) {
                return NotFound($"Customer with ID {customerId} not found.");
            }
            return Ok(customer);
        }

        [HttpPost("add")]
        public IActionResult AddCustomer(Customer customer) {

            _customerService.AddCustomer(customer);
            return Ok();
                
        }
    }
}
