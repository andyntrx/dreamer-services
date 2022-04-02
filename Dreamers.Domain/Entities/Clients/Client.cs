
using Dreamers.Domain.Entities.ValueObjects;

namespace Dreamers.Domain.Entities.Clients
{
    public class Client : Person
    {
        public ClientType ClientType { get; set; }
        public ClientProfile ClientProfile { get; set; }
    }
}
