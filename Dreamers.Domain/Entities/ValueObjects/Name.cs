using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.ValueObjects
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
