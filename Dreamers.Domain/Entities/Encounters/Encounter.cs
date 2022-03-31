using Dreamers.Domain.Entities.Clients;
using Dreamers.Domain.Entities.Documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Encounters
{
    public class Encounter
    {
        public Client Client { get; set; }
        public EncounterType EncounterType { get; set; }
        public List<Document> Documents { get; set; }
    }
}
