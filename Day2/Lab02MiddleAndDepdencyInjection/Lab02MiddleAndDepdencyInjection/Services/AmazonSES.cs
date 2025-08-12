using System;
using System.Threading.Tasks;

namespace Lab02MiddleAndDepdencyInjection.Services
{
    public class AmazonSES : IEmailService
    {

        public AmazonSES() {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AmazonSES created "+this.GetHashCode());
            Console.ResetColor();

        }

        public Task SendEmailAsync(string email, string subject)
        {
           return Task.Run(() => {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Amazon SES: Sending email to {email} with subject '{subject}'");
                Console.ResetColor();

            });
           

        }
    }
}
