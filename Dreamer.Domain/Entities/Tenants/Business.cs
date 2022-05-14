using Dreamer.Common.Entities;
using Dreamer.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.Tenants
{
    public class Business : Entity
    {
        public string Name { get; set; }
        public Guid TenantId { get; set; }
        public TenantGroup Group { get; set; }
        public Representor Representor { get; set; }
    }
}
