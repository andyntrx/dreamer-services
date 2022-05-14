using Dreamer.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Dreamer.Infrastructure.Services
{
    public class SmtpEmailDispatcher : IEmailDispatcher
    {
        public void Dispatch(MailMessage mailMessage)
        {
            throw new NotImplementedException();
        }
    }
}
