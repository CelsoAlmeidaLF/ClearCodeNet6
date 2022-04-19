using System.Data;

namespace Systekna.Infrastructure
{
    public interface IImportFile
    {
        DataTable ImportDataFile(string path);
    }
}