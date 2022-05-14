using Dreamer.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.ValueObjects
{
    public class PhoneNumber : ValueObject
    {
        public PhoneNumber(string areaCode, string number)
        {
            AreaCode = areaCode;
            Number = number;
        }

        public string AreaCode { get; private set; }
        public string Number { get; private set; }

        public string FullNumber()
        {
            return $"+{AreaCode} {Number}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AreaCode;
            yield return Number;
        }
    }
}
