using Systekna.Core.Valid;
using System.Data;

namespace Systekna.Application
{
    public interface IGetBusiness<T>
    {
        DataTable ReturnDataTable(T entity);
        Valid ExportDataTable(DataTable data, string path);
    }
}
