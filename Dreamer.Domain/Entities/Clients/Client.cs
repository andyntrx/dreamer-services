
using Dreamer.Domain.Entities.Documents;
using Dreamer.Domain.Entities.Shared;
using Dreamer.Domain.Entities.ValueObjects;
using System.Collections.Generic;

namespace Dreamer.Domain.Entities.Clients
{
    public class Client : Person
    {
        public ClientType ClientType { get; set; }
        public ClientProfile ClientProfile { get; set; }
        public List<Dependant> Dependants { get; set; }
        public List<Document> Documents { get; set; }

    }
}
