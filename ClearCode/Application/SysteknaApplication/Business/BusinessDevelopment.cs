using Systekna.Core;
using Systekna.Core.Entity;
using Systekna.Core.Interface;
using Systekna.Core.ValidObject;
using System.Data;
using System.Reflection;

namespace Systekna.Application
{
    public class BusinessDevelopment : Business, IBusiness<Entity>
    {
        // Exporta dados da base para o arquivo.
        public override Valid ExportDataTable(DataTable data, string path)
        {
            IsValid = new Valid() { ValidValue = true, StringMethod = MethodBase.GetCurrentMethod().Name };      
            base.SendEmail("celso.almeida.leite@hotmail.com", "Arquivo Exportado com sucesso.", $"Data da Exportação: {User.DataUserLogin}.");
            return IsValid;
        }

        // Importa dados do arquivo para base.
        public override DataTable ImportDataFile(string path)
        {
            DataTable Dta = new DataTable("Table");
            return Dta != null ? Dta : base.ImportDataFile(path);
        }

        // Retorna tabela da base.
        public override DataTable ReturnDataTable(Entity entity)
        {
            DataTable Dta = new DataTable("Table");
            return Dta != null ? Dta : base.ReturnDataTable(entity);
        }

        #region "CRUD"

        // Cadastra novo registro na base.
        public override Valid InsertRepository(Entity entity)
        {
            base.SendEmail("celso.almeida.leite@hotmail.com", "Registro Cadastrado com sucesso!", $"Data do Cadastro: {entity.DataCriação}.");
            return entity.IsValidRegister ? new Valid() { ValidValue = true, StringMethod = MethodBase.GetCurrentMethod().Name } : base.InsertRepository(entity);
        }

        // Altualiza arquivos.
        public override Valid UpdateRepository(Entity entity)
        {
            // Valida Arquivo ...
            base.SendEmail("celso.almeida.leite@hotmail.com", "Registro Atualizado com sucesso!", $"Data da Alteração: {entity.DataAlteração}.");
            return entity.IsValidUpdate ? new Valid() { ValidValue = true, StringMethod = MethodBase.GetCurrentMethod().Name } : base.UpdateRepository(entity);
        }

        // Deleta regustro da base.
        public override Valid DeleteRepository(Entity entity)
        {
            base.SendEmail("celso.almeida.leite@hotmail.com", "Registro Removido com sucesso!", $"Data da Exclusão: {entity.DataExclusão}.");
            return entity.IsValidDelete ? new Valid() { ValidValue = true, StringMethod = MethodBase.GetCurrentMethod().Name } : base.DeleteRepository(entity);
        }

        #endregion
    }
}