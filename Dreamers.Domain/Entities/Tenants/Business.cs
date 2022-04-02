using Dreamers.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Tenants
{
    public class Business : Entity
    {
        public Guid TenantId { get; set; }
        public TenantGroup Group { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
