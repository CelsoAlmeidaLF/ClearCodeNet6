using Systekna.Core.Entity;
using System;
using System.Data;

namespace Systekna.Infrastructure
{
    public class Repository : Data.DataBase
    {
        public Repository(string stringConection) : base(stringConection)
        {
        }

        public DataTable GetDataTable(EntityBusiness entity)
        {
            DataTable dt = ExecDataTable("");
            dt.TableName = dt.Rows.Count > 0 ? "TableName" : String.Empty; 
            return dt;
        }
    }
}