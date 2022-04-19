using Systekna.Infrastructure.Interface;
using System.Data;

namespace Systekna.Infrastructure.File
{
    public class Excel : IExcel
    {
        public bool Export(DataTable data, string path)
        {
            return true;
        }

        public DataTable Import(string path)
        {
            return new DataTable("empty table import");
        }
    }
}
