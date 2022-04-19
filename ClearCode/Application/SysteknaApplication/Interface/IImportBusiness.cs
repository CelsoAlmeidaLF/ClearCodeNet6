using System.Data;

namespace Systekna.Application
{
    public interface IImportBusiness
    {
        DataTable ImportDataTable(string path);
    }
}