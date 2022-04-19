using Systekna.Core.Valid;

namespace Systekna.Application
{
    public interface IUpInsBusiness<T>
    {
        Valid Cadastrar(T entity);
        Valid Alterar(T entity);
        Valid Excluir(T entity);
    }
}
