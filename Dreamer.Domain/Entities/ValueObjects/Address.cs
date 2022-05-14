using Dreamer.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.ValueObjects
{
    public class Address : ValueObject
    {

        public string Address1 { get; private set; }
        public string? Address2 { get; private set; }
        public String City { get; private set; }
        public StatesType State { get; private set; }
        public String Country { get; private set; }
        public String ZipCode { get; private set; }

        public Address() { }

        public Address(string address1, string address2, string city, StatesType state, string zipcode, string country = "US")
        {
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipcode;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            // Using a yield return statement to return each element one at a time
            yield return Address1;
            yield return Address2 ?? "";
            yield return City;
            yield return State;
            yield return Country;
            yield return ZipCode;
        }
    }
}
