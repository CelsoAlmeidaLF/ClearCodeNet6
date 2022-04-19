namespace Systekna.Application
{
    public interface IBusiness<T> : IUpInsBusiness<T>, IGetBusiness<T>, IImportBusiness
    {
    }
}