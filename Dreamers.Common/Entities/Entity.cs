using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Common.Entities
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
        public Guid Ucid { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        protected Entity()
        {
            Ucid = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (ReferenceEquals(null, compareTo))
                return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b) => !(a == b);

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }
    }
}
