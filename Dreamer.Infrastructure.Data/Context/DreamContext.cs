
using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities.Clients;
using Dreamer.Domain.Entities.Documents;
using Dreamer.Domain.Entities.Emails;
using Dreamer.Domain.Entities.Tenants;
using Microsoft.EntityFrameworkCore;

namespace Dreamer.Infrastructure.Data.Context
{
    public class DreamContext : DbContext, IDreamContext
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
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
    }
}
