using Lab02CustomerWebAPI.Domain;
using Lab02CustomerWebAPI.DTO;
using Lab02CustomerWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab02CustomerWebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository repository)
        {

            _customerRepository = repository;
        }

        [HttpGet("allcustomers")]
        public IActionResult Get()
        {

            List<CustomerDTO> dtos = new List<CustomerDTO>();
            List<Customer> customers = _customerRepository
                .GetCustomers();

            foreach (Customer customer in customers)
            {
                var splitNames = customer.FullName.Split();

                dtos.Add(new CustomerDTO
                {
                    Id = customer.Id,
                    FirstName = splitNames[0],
                    LastName = splitNames[1]
                });
            }

            //if(dtos.Count==0)
            //    return NotFound();

            return Ok(dtos);

        }

        [HttpGet("customerbyid/{customerId}")]
        public IActionResult Get(int customerId)
        {


            var customer = _customerRepository.GetCustomerById(customerId);
            return Ok(new CustomerDTO
            {
                Id = customer.Id,
                FirstName = customer.FullName.Split()[0],
                LastName = customer.FullName.Split()[1]
            }
                );
        }

        [HttpPost("addcustomer")]
        public IActionResult Add(CustomerDTO dto)
        {

            var fullName = dto.FirstName + " " + dto.LastName;
            var customer = new Customer
            {
                FullName = fullName,


            };

            _customerRepository.AddCustomer(customer);

            return Created();

        }

        [HttpPut("update/{customerId}")]
        public IActionResult Update(int customerId, CustomerDTO dto)
        {
            if (customerId == dto.Id)
            {

                var customer = new Customer
                {
                    FullName = dto.FirstName + " " + dto.LastName,
                    Id = dto.Id
                };

                _customerRepository.UpdateCustomer(customer);
                return Ok(customer);

            }

            return BadRequest();

        }

        [HttpDelete("{customerId}")]
        public IActionResult Delete(int customerId)
        {
            var customer = _customerRepository.GetCustomerById(customerId);
            if (customer == null)
            {
                return NotFound();
            }
            _customerRepository.DeleteCustomer(customerId);
            return NoContent();
        }


    }
}
