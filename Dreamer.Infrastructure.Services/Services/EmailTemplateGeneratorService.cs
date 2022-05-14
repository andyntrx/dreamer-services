using Dreamer.Domain.Entities.Emails;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Dreamer.Domain.Services
{
    public class EmailTemplateGeneratorService : IEmailGeneratorService
    {
        public MailMessage Generate(object data, EmailTemplate emailTemplate)
        {
            var email = new MailMessage();

            email.IsBodyHtml = true;
            email.Body = emailTemplate.GetHtmlContent();

            return email;
        }
    }
}
