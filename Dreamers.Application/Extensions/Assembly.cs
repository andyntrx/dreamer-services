using Dreamers.Domain.Interfaces;
using Dreamers.Infra.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Dreamers.Application.Extensions
{
    public static class Assembly
    {
        public static void Startup(IServiceCollection services)
        {
            services.AddMediatR(System.Reflection.Assembly.GetExecutingAssembly());

            services.AddScoped<IEmailDispatcher, SmtpEmailDispatcher>();
        }
    }
}
