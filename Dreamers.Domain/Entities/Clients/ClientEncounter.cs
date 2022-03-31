using Dreamers.Domain.Entities.Encounters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Clients
{
    public class ClientEncounter
    {
        public Guid ClientUcid { get; set; }
        public Client Client { get; set; }
        public List<Encounter> Encounters { get; set; }
    }
}
