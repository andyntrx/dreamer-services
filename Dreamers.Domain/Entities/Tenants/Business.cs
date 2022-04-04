using Dreamers.Common.Entities;
using Dreamers.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Tenants
{
    public class Business : Entity
    {
        public string Name { get; set; }
        public Guid TenantId { get; set; }
        public TenantGroup Group { get; set; }
        public Representor Representor { get; set; }
    }
}
