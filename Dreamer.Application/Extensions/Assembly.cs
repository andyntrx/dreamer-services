using Dreamer.Application.Abstractions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Dreamer.Application.Extensions
{
    public static class Assembly
    {
        public static void Startup(IServiceCollection services)
        {
            services.AddMediatR(System.Reflection.Assembly.GetExecutingAssembly());
        }
    }
}
