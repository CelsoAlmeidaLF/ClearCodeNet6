using Systekna.Core.Valid;
using System.Data;

namespace Systekna.Application.Interface
{
    public interface IBusinessConsulta<T>
    {
        DataTable ReturnDataTable(T entity);
        Valid ExportDataTable(DataTable data, string path);
    }
}
