using Dreamer.Common.Entities;
using Dreamer.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.Clients
{
    public class ClientService : Entity
    { 
        public Guid ClientUcid { get; set; }
        public List<Service> Services { get; set; }
    }
}
