using Dreamer.Common.Entities;
using Dreamer.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.Shared
{
    public abstract class Person : Entity
    {
        public Name Name { get; set; }
        public Contact Contact { get; set; }    
        public DateTime BirthDate { get; set; }
    }
}
