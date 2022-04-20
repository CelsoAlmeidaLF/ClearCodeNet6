using System.Data;

namespace Systekna.Infrastructure
{
    public interface IExportFile
    {
        bool Export(DataTable data, string path);
    }
}