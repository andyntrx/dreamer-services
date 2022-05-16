using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities.Emails;
using Dreamer.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Infrastructure.Services.Extensions
{
    public static class Assembly
    {
        public static void Startup(IServiceCollection services)
        {
            services.AddTransient<IEmailDispatcher, SmtpEmailDispatcher>();
            services.AddTransient<IEmailGeneratorService, EmailTemplateGeneratorService>();
        }
    }
}
