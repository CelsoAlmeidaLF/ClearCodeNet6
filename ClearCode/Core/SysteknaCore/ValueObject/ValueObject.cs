using System;
using System.Data;
using System.Data.SqlClient;

namespace Systekna.Core.ValueObject
{
    public abstract class ValueObject
    {
        #region "Monta Parametro"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="parameters"></param>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="sqlDbType"></param>
        protected void MontarParameter(int index, SqlParameter[] parameters,
            string parameterName, object value, SqlDbType sqlDbType)
        {
            parameters[index] = new SqlParameter();
            parameters[index].ParameterName = parameterName;
            if (value == null)
                value = DBNull.Value;
            parameters[index].SqlValue = value;
            parameters[index].SqlDbType = sqlDbType;
        }

        #endregion
    }
}