using Dreamers.Common.Entities;
using Dreamers.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Shared
{
    public class Contact : Entity
    {
        public Address Address { get; set; }
        public string EmailAddress { get; set; }
        public PhoneNumber PhoneNumber { get; private set; }
    }
}
