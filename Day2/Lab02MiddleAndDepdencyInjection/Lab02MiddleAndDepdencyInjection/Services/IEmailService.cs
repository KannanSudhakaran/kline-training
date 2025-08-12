using System.Threading.Tasks;

namespace Lab02MiddleAndDepdencyInjection.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email,string subject);
    }
}
