using Dreamer.Domain.Entities.Clients;
using Dreamer.Domain.Entities.Documents;
using Dreamer.Domain.Entities.Emails;
using Dreamer.Domain.Entities.Tenants;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Abstractions
{
    public interface IDreamContext 
    {
        public DbSet<ClientService> ClientServices { get; set; }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Business> Customers { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
