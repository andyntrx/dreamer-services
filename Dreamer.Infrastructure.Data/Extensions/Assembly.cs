

using Dreamer.Application.Abstractions;
using Dreamer.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dreamer.Infrastructure.Data.Extensions
{
    public static class Assembly
    {
        public static void Startup(IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<IDreamContext, DreamContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

        }
    }
}
