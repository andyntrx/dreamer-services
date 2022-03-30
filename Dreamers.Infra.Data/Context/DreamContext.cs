
using Dreamers.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dreamers.Infra.Data.Context
{
    public class DreamContext : DbContext
    {
        public DreamContext(DbContextOptions<DreamContext> options)
            : base(options)
        {
        }

        public DbSet<ClientProfile> ClientProfiles { get; set; }
    }
}
