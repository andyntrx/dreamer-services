using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Common.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public Guid Ucid { get; set; }
    }
}
