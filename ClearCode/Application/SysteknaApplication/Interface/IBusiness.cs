using Systekna.Core.Interface;

namespace Systekna.Application
{
    public interface IBusiness<T> : IUpInsBusiness<T>, IGetBusiness<T>, IImportDataFile
    {
    }
}