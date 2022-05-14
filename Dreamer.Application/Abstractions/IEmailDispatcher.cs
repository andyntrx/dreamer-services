using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Dreamer.Application.Abstractions
{
    public interface IEmailDispatcher
    {
        void Dispatch(MailMessage mailMessage);
    }
}
