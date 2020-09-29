
using System.Threading.Tasks;
using eShop.Common.Core.Entities;

namespace eShop.Common.Core.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailRequest request);
        Task SendWelcomeEmailAsync(WelcomeEmailRequest request);
    }
}
