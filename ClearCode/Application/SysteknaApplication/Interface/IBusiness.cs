using Systekna.Core.Valid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systekna.Application.Interface
{
    public interface IBusiness<T>
    {
        Valid Cadastrar(T entity);
        Valid Alterar(T entity);
        Valid Excluir(T entity);
    }
}
