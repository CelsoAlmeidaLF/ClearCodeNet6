using Systekna.Core.ValueObject;
using Systekna.Infrastructure.Interface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Systekna.Data
{
    public abstract partial class DataBase : ValueObject, IDAO
    {
        private SqlConnection _conn = null;
        private SqlCommand _cmmd = null;

        #region "Construtor e Conexão"

        public DataBase(string stringConnection)
        {
            _conn = new SqlConnection(stringConnection);
        }

        public void Close()
        {
            if (_conn.State == ConnectionState.Open)
                _conn.Close();
        }

        public SqlConnection Open()
        {
            if (_conn.State == ConnectionState.Closed)
                _conn.Open();

            return _conn;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public SqlDataAdapter ExecDataAdapter(string cmd, SqlParameter[] parameters = null, 
            CommandType commandType = CommandType.Text)
        {
            try
            {
                _cmmd = new SqlCommand(cmd, Open());
                _cmmd.Parameters.Clear();

                _cmmd.CommandType = commandType;

                if (parameters != null)
                    _cmmd.Parameters.AddRange(parameters);

                return new SqlDataAdapter(_cmmd);
            }
            catch (SqlException sqlex)
            {
                throw new Exception(sqlex.Message);
            }
            finally
            {
                Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public SqlDataReader ExecDataReader(string cmd, SqlParameter[] parameters = null, 
            CommandType commandType = CommandType.Text)
        {
            try
            {
                _cmmd = new SqlCommand(cmd, Open());
                _cmmd.Parameters.Clear();

                _cmmd.CommandType = commandType;

                if (parameters != null)
                    _cmmd.Parameters.AddRange(parameters);

                return _cmmd.ExecuteReader();
            }
            catch (SqlException sqlex)
            {
                throw new Exception(sqlex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmmd"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public SqlBulkCopy ExecSqlBulkCopy(string cmmd, SqlParameter[] parameters = null, 
            CommandType commandType = CommandType.Text)
        {
            _cmmd = new SqlCommand(cmmd, Open());
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet ExecDataSet(string cmd, SqlParameter[] parameters = null)
        {
            DataSet set = new DataSet();
  
            try
            {
                CommandType commandType = CommandType.StoredProcedure;
                var da = ExecDataAdapter(cmd, parameters, commandType).Fill(set);
                return set;
            }
            catch (SqlException sqlex)
            {
                throw new Exception(sqlex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public DataTable ExecDataTable(string cmd, SqlParameter[] parameters = null,
            CommandType commandType = CommandType.Text)
        {
            DataTable dt = new DataTable();

            try
            {
                var da = ExecDataAdapter(cmd, parameters, commandType).Fill(dt);
                return dt;
            }
            catch (SqlException sqlex)
            {
                throw new Exception(sqlex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public object ExecDataScalar(string cmd, SqlParameter[] parameters = null,
            CommandType commandType = CommandType.Text)
        {
            try
            {
                _cmmd = new SqlCommand(cmd, Open());
                _cmmd.Parameters.Clear();

                _cmmd.CommandType = commandType;

                if (parameters != null)
                    _cmmd.Parameters.AddRange(parameters);

                return _cmmd.ExecuteScalar();
            }
            catch (SqlException sqlex)
            {
                throw new Exception(sqlex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}