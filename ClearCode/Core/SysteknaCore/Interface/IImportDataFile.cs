using System.Data;

namespace Systekna.Core.Interface
{
    public interface IImportDataFile
    {
        DataTable ImportDataFile(string path);
    }
}