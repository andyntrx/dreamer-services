using Dreamers.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Dreamers.Infra.Services
{
    public class SmtpEmailDispatcher : IEmailDispatcher
    {
        public void Dispatch(MailMessage mailMessage)
        {
            throw new NotImplementedException();
        }
    }
}
