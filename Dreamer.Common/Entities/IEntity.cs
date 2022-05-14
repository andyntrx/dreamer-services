using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Common.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public Guid Ucid { get; set; }
    }
}
