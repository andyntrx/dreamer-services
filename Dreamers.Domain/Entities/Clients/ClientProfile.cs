using Dreamers.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Clients
{
    public class ClientProfile : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    

    }
}
