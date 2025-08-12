using Lab03ControllerAndActions.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Lab03ControllerAndActions.Controllers
{

    [MyLogThisAction]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult Image() { 
        
            return File("/burger.jpg", "image/jpeg");

        }

        [Route("/v1/kline/myimage",Name ="myimageRoute")]
        
        public IActionResult GetImage() {

            return Image();
        }

        public IActionResult RedirectV1() { 
        
          return RedirectToRoute("myimageRoute");
        }

    }
}
