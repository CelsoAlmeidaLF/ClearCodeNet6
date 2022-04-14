using System;
using System.Data;
using Systekna.Core.Valid;

namespace Systekna.Core.Entity
{
    public abstract class EntityBase : EntityUser
    {
        public int? ID { get; set; } = null;
        public DateTime? DataCriação { get; set; } = null;
        public DateTime? DataAlteração { get; set; } = null;
        public bool Exclusão { get; set; } = false;
        public DateTime? DataExclusão { get; set; } = null;

        #region method
        /// <summary>
        /// Valida Regsitro
        /// </summary>
        /// <param name="obj">Objeto é valido?</param>
        public static void IsValid(object obj)
        {
            Valid.IsValid.Value = obj != null ? true : false;
        }

        #endregion
    }
}
