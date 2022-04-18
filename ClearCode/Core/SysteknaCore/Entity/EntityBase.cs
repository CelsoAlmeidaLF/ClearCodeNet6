using System;
using System.Data;

namespace Systekna.Core.Entity
{
    public abstract class EntityBase : EntityUser
    {
        public int? ID { get; set; } = null;
        public DateTime? DataCriação { get; set; } = null;
        public DateTime? DataAlteração { get; set; } = null;
        public bool Exclusão { get; set; } = false;
        public DateTime? DataExclusão { get; set; } = null;
    }
}
