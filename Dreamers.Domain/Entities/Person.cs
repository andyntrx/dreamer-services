using Dreamers.Common.Entities;
using Dreamers.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities
{
    public abstract class Person : Entity
    {
        public Name Name { get; set; }
        public Address Address { get; set; }
    }
}
