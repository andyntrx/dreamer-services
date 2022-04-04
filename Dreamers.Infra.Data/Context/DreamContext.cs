    
using Dreamers.Domain.Entities.Clients;
using Dreamers.Domain.Entities.Documents;
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

        public DbSet<ClientService> ClientServices { get; set; }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Business> Customers { get; set; }
        public DbSet<Dependant> Dependants { get; set; }    
        public DbSet<Document> Documents { get; set; }
    }
}
