﻿using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Dreamers.Domain.Entities.Emails
{
    public interface IEmailGenerator
    {
        MailMessage Generate(object objHolder, EmailTemplate emailTemplate);
    }
}