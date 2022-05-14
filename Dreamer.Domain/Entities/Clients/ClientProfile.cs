using Dreamer.Common.Entities;
using Dreamer.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.Clients
{
    public class ClientProfile : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public Address Address { get; set; }
    }
}
