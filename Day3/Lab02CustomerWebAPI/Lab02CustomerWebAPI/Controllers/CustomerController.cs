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

        public CustomerController(ICustomerRepository repository) { 
        
            _customerRepository = repository;
        }

        [HttpGet("allcustomers")]
        public IActionResult Get()
        {

            List<CustomerDTO> dtos = new List<CustomerDTO>();
            List<Customer> customers= _customerRepository
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


        
    }
}
