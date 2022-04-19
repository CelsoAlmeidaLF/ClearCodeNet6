using Systekna.Core.Valid;

namespace Systekna.Application
{
    public interface IUpInsBusiness<T>
    {
        Valid InsertRepository(T entity);
        Valid UpdateRepository(T entity);
        Valid DeleteRepository(T entity);
    }
}
