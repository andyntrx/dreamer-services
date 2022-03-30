
using Dreamers.Domain.Entities;
using System.Data.Entity;

namespace Dreamers.Infra.Data.Context
{
    public class DreamContext : DbContext
    {
        public DbSet<ClientProfile> ClientProfiles { get; set; }
    }
}
