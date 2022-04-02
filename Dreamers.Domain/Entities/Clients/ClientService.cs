using Dreamers.Common.Entities;
using Dreamers.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Clients
{
    public class ClientService : Entity
    { 
        public Guid ClientUcid { get; set; }
        public List<Service> Services { get; set; }
    }
}
