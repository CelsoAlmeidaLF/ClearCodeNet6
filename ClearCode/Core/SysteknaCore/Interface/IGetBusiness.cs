using Systekna.Core.ValidObject;
using System.Data;

namespace Systekna.Core.Interface
{
    public interface IGetBusiness<T>
    {
        DataTable ReturnDataTable(T entity);
        Valid ExportDataTable(DataTable data, string path);
    }
}
