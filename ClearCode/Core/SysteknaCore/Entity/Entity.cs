using Systekna.Core.ValidObject;

namespace Systekna.Core.Entity
{
    public class Entity : EntityBase
    {
        public bool IsValidUpdate { get { return DataAlteração != null ? true : false; } }
        public bool IsValidRegister { get { return DataCriação != null ? true : false; } }
        public bool IsValidDelete { get { return DataExclusão != null ? true : false; } }
        public bool GetValid { get { return Valid.ValidValue; } }

        public Entity()
        {
            Valid = new Valid();
        }
    }
}