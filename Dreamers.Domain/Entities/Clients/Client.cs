using Dreamers.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Clients
{
    public class Client : Entity
    {
        public ClientType ClientType { get; set; }

        public ClientProfile ClientProfile { get; set; }
    }
}
