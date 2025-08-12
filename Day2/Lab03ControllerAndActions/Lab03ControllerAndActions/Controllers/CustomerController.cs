using Lab03ControllerAndActions.Filters;
using Lab03ControllerAndActions.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lab03ControllerAndActions.Controllers
{
    [MyLogThisAction]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var c1 = new Customer
            {
                City = "New York",
                Id = 1,
                Name = "Lin"
            };
            return View(c1);
        }
    }
}
