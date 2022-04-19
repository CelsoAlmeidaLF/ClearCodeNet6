
using Systekna.Core.Valid;

namespace Systekna.Application
{
    public partial class BusinessProperties
    {
        public static Valid IsValidCadastro { get; set; }
        public static Valid IsValidAlteração { get; set; }
        public static Valid IsValidExclusão { get; set; }
        public static Valid IsValidExport { get; set; }

    }
}
