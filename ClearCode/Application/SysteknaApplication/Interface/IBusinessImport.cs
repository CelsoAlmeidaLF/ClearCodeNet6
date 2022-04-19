using System.Data;

namespace Systekna.Application
{
    public interface IBusinessImport
    {
        DataTable ImportDataTable(string path);
    }
}