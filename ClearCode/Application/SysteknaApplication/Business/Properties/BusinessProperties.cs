
using Systekna.Core.Valid;
using System.Data;

namespace Systekna.Application
{
    public partial class Business
    {
        public static Valid IsValidCadastro { get; set; }
        public static Valid IsValidAlteração { get; set; }
        public static Valid IsValidExclusão { get; set; }
        public static Valid IsValidExport { get; set; }

        public static Valid IsValidTable(DataTable data)
        {
            return new Valid()
            {
                ValidValue = data.Rows.Count > 0 ? true : false
            };
        }

    }
}
