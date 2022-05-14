using Dreamer.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.Services
{
    public class Service : Entity
    {
        public Representor Representor { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
