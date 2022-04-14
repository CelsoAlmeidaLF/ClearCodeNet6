using Systekna.Core.Entity;
using System.Data;

namespace Systekna.Application.Interface
{
    /// <summary>
    /// Definições da Regra de Negócio
    /// </summary>
    public interface IBusiness<T>
    {
        /// <summary>
        /// Consulta tabela na base de dados. 
        /// </summary>
        /// <param name="entity">Parâmetro de registro.</param>
        /// <returns></returns>
        DataTable GetDataTable(T entity);
        bool? IsComplet();
    }
}
