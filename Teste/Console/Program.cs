using Systekna.Application;
using Systekna.Core.Entity;
using System.Data;

Console.Title = "Console Test CRUD";

// Entidades do negócio.
Entity entity = new Entity();

// Chama regra de negócio.
IBusiness<Entity> _business = new Business();
ISendEmail _send = new BusinessEmail();

#region "Methods"

// Cadastra item no Repository.
Business.IsValidCadastro = _business.InsertRepository(entity);
if (Business.IsValidCadastro.ValidValue)
{
    _send.SendEmail(entity.Email, null, "cadastro com sucesso!", "...", false);
}

// Altera item no Repository.
Business.IsValidAlteração = _business.UpdateRepository(entity);
if (Business.IsValidAlteração.ValidValue)
{
    _send.SendEmail(entity.Email, null, "alteração com sucesso!", "...", false);
}

// Exclui item no Repository.
Business.IsValidExclusão = _business.DeleteRepository(entity);
if (Business.IsValidExclusão.ValidValue)
{
    _send.SendEmail(entity.Email, null, "exclusão com sucesso!", "...", false);
}

// Retorna DataTable do Repository.
DataTable dtIn = _business.ReturnDataTable(new Entity());
if(Business.IsValidTable(dtIn).ValidValue)
{
    _send.SendEmail(entity.Email, null, "return datatable com sucesso!", "...", false);
}

// Exporta Table para um novo arquivo.
Business.IsValidExport = _business.ExportDataTable(dtIn, Directory.GetCurrentDirectory());
if (Business.IsValidExclusão.ValidValue)
{
    _send.SendEmail(entity.Email, null, "exportado com sucesso!", "...", false);
}

// Importa Data do Arquivo para Table.
DataTable dtOut = _business.ImportDataFile(Directory.GetCurrentDirectory());
if (Business.IsValidTable(dtOut).ValidValue)
{
    _send.SendEmail(entity.Email, null, "importação com sucesso!", "...", false);
}

#endregion

#region "Console"
Console.Read();
#endregion