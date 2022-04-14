using Systekna.Application.Interface;
using Systekna.Core.Entity;
using Valid = Systekna.Core.Valid;
using System.Data;
using Systekna.Infrastructure;

namespace Systekna.Application.Business
{
    public class Business : EntityBusiness, IBusiness<EntityBusiness>
    {
        private DataTable data = null;

        public DataTable GetDataTable(EntityBusiness entity)
        {
            // Valida se existe parametro
            IsValid(entity);
            
            // ConsultaTableBase
            data = Valid.IsValid.Value.Equals(true) ? new Repository(Framework.StringConection).GetDataTable(entity) : null;
            
            // Retorna DataTable
            return data;
        }
        public bool? IsComplet()
        {
            return data != null ? true : false;
        }
    }
}
