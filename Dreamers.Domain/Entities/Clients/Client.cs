
using Dreamers.Domain.Entities.Documents;
using Dreamers.Domain.Entities.Shared;
using Dreamers.Domain.Entities.ValueObjects;
using System.Collections.Generic;

namespace Dreamers.Domain.Entities.Clients
{
    public class Client : Person
    {
        public ClientType ClientType { get; set; }
        public ClientProfile ClientProfile { get; set; }
        public List<Dependant> Dependants { get; set; }
        public List<Document> Documents { get; set; }
    }
}
