using Lab03JWTAPI.Data;
using Lab03JWTAPI.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Lab03JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private ApplicationDbContext _dbcontext;

        public EmployeeController(ApplicationDbContext dbcontext)
        { 
         _dbcontext = dbcontext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(_dbcontext.Employees.ToList());
        }

        [HttpPost]
        [Authorize(Roles ="admin")]
        public IActionResult CreateEmployee(Employee emp) { 
        
            _dbcontext.Employees.Add(emp);
            _dbcontext.SaveChanges();

            return Created();
        
        }

    }
}
