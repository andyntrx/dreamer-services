using Dreamer.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.ValueObjects
{
    public class Ssn : ValueObject
    {
        public string Number { get; set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Number;
        }
    }
}
