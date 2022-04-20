using Systekna.Core.ValidObject;

namespace Systekna.Core.Interface
{
    public interface IUpInsBusiness<T>
    {
        Valid InsertRepository(T entity);
        Valid UpdateRepository(T entity);
        Valid DeleteRepository(T entity);
    }
}
