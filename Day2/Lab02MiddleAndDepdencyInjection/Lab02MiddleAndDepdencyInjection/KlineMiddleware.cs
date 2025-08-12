using Lab02MiddleAndDepdencyInjection.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Lab02MiddleAndDepdencyInjection
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class KlineMiddleware
    {
        private readonly RequestDelegate _nextMiddleware;

        public KlineMiddleware(RequestDelegate next)
        {
            _nextMiddleware = next;
        }

        public async Task Invoke(HttpContext httpContext, IEmailService emailSerice)
        {
            //pre processing logic here
            Console.WriteLine("prepproceesing...logic"+emailSerice.GetHashCode());
            await emailSerice.SendEmailAsync("middlware@kline", "middleware test");
            await _nextMiddleware(httpContext);
            // post processing logic here
            Console.WriteLine("post processing...logic");

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class KlineMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyKlineMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<KlineMiddleware>();
        }
    }
}
