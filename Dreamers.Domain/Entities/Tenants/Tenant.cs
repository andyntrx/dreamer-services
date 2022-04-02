using Dreamers.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Tenants
{
    public class Tenant : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
