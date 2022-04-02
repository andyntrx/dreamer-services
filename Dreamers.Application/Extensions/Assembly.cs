using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Application.Extensions
{
    public static class Assembly
    {
        public static void Startup(IServiceCollection services)
        {
            services.AddMediatR(System.Reflection.Assembly.GetExecutingAssembly());
        }
    }
}
