
using Dreamers.Domain.Entities;
using Dreamers.Domain.Entities.Clients;
using Dreamers.Domain.Entities.Tenants;
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
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Customers { get; set; }
    }
}
