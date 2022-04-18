using System.Data.SqlClient;
using System.Data;

namespace Systekna.Infrastructure.Interface
{
    public interface IDAO
    {
        DataSet ExecDataSet(string cmd, SqlParameter[] parameters = null);
  
        DataTable ExecDataTable(string cmd, SqlParameter[] parameters = null, 
            CommandType commandType = CommandType.Text);

        SqlBulkCopy ExecSqlBulkCopy(DataTable data, string tableName);
 
        SqlDataReader ExecDataReader(string cmd, SqlParameter[] parameters = null,
            CommandType commandType = CommandType.Text);
   
        SqlDataAdapter ExecDataAdapter(string cmd, SqlParameter[] parameters = null, 
            CommandType commandType = CommandType.Text);
 
        object ExecDataScalar(string cmd, SqlParameter[] parameters = null, 
            CommandType commandType = CommandType.Text);
  
        void Close();
        
    }
}
