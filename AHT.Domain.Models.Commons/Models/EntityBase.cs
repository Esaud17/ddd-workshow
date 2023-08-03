using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace AHT.Domain.Commons.Models
{
    public abstract class EntityBase<TId>
    {
       
        public virtual TId Id { get; set; }

        public abstract string[] Validate();

        public override bool Equals(object entity)
        {
            return entity != null && entity is EntityBase<TId> && this == (EntityBase<TId>)entity;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public static bool operator ==(EntityBase<TId> entity1, EntityBase<TId> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null) return true;
            if ((object)entity1 == null || (object)entity2 == null) return false;
            if (entity1.Id.ToString() == entity2.Id.ToString()) return true;
            return false;
        }

        public static bool operator !=(EntityBase<TId> entity1, EntityBase<TId> entity2)
        {
            return (!(entity1 == entity2));
        }
    }
}
