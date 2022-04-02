using Dreamers.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Services
{
    public class Service : Entity
    {
        public Representor Representor { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
