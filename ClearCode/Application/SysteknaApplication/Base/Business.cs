
using Systekna.Core;
using Systekna.Core.Entity;
using Systekna.Core.Interface;
using Systekna.Core.ValidObject;

using System;
using System.Data;
using System.Reflection;

namespace Systekna.Application
{
    public partial class Business : IBusiness<Entity>
    {
        protected ISendEmail SEmail;

        protected Valid IsValid { get; set; }
        protected EntityUser User { get; set; }

        public virtual Valid UpdateRepository(Entity entity)
        {
            return new Valid(MethodBase.GetCurrentMethod().Name);
        }
        public virtual Valid InsertRepository(Entity entity)
        {
            return new Valid(MethodBase.GetCurrentMethod().Name);
        }

        public void SendEmail(string email, string assunto, string corpo)
        {
            SEmail = new Email();
            User = new EntityUser() { Email = email};
            bool? mail = SEmail.SendEmail(User.Email, null, assunto, corpo, false);
        }

        public virtual Valid DeleteRepository(Entity entity)
        {
            return new Valid(MethodBase.GetCurrentMethod().Name);
        }
        public virtual Valid ExportDataTable(DataTable data, string path)
        {
            return new Valid(MethodBase.GetCurrentMethod().Name);
        }
        public virtual DataTable ReturnDataTable(Entity entity)
        {
            return null;
        }
        public virtual DataTable ImportDataFile(string path)
        {
            return null;
        }
    }
}