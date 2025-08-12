using Lab02MiddleAndDepdencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab02MiddleAndDepdencyInjection.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEmailService _emailServcie;//hasA

        public HomeController(IEmailService emailService)
        {
            _emailServcie = emailService;
            Console.WriteLine($"HomeController created {_emailServcie.GetHashCode()}");

        }

        public async Task<IActionResult> Index()
        {
            await _emailServcie.SendEmailAsync("indexaction@keline", "insi index");
            return Content("<h1>Index page</h1>","text/html");
        }
    }
}
