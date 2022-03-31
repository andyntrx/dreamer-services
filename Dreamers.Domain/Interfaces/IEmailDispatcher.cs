using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Dreamers.Domain.Interfaces
{
    public interface IEmailDispatcher
    {
        void Dispatch(MailMessage mailMessage);
    }
}
