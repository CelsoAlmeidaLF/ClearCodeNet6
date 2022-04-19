using System.Data;

namespace Systekna.Infrastructure
{
    public interface IImportFile
    {
        DataTable Import(string path);
    }
}