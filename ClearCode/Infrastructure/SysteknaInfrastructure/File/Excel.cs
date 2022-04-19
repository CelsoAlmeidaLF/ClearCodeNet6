using Systekna.Infrastructure.Interface;
using System.Data;

namespace Systekna.Infrastructure.File
{
    public class Excel : IImportFile, IExportFile
    {
        public bool Export(DataTable data, string path)
        {
            return true;
        }
    }
}
