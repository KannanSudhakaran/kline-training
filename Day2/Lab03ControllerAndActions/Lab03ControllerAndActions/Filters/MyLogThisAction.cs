using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lab03ControllerAndActions.Filters
{
    public class MyLogThisAction:ActionFilterAttribute
    {
        private string _controllerName = string.Empty;
        private string _actionName = string.Empty;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _controllerName = context.RouteData.Values["controller"].ToString();
            _actionName = context.RouteData.Values["action"].ToString();

            Console.WriteLine($"Before execution action {_actionName} inside {_controllerName} time is : {DateTime.Now.ToShortTimeString()}");
           // context.Result = new RedirectResult("https://www.google.com");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"After execution action {_actionName} inside {_controllerName} , time is: {DateTime.Now.ToShortTimeString()}");
        }
    }
}
