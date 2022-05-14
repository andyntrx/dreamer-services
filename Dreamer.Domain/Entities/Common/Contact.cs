using Dreamer.Common.Entities;
using Dreamer.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.Shared
{
    public class Contact : Entity
    {
        public Address Address { get; set; }
        public string EmailAddress { get; set; }
        public PhoneNumber PhoneNumber { get; private set; }
    }
}
