using System.Net.Mail;

namespace Dreamers.Infra.Services
{
    public interface IEmailDispatcher
    {
        void Dispatch(MailMessage mailMessage);
    }
}