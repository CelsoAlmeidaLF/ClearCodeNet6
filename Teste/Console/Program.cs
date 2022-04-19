using Systekna.Application;
using Systekna.Core.Entity;
using System.Data;
Console.Title = "Console Test CRUD";

// Entidades do negócio.
Entity entity = new Entity();

// Chama regra de negócio.
IBusiness<Entity> _business = new BusinessProperties();
ISendEmail _send = new BusinessEmail();

#region "Methods"

// Cadastra um item no Repository.
BusinessProperties.IsValidCadastro = _business.Cadastrar(entity);
if (BusinessProperties.IsValidCadastro.ValidValue)
{
    _send.SendEmail(entity.Email, null, "cadastro com sucesso", "...", false);
    //Debug.WriteLine($"Cadastrado com sucesso!");
}

// Altera um item no Repository.
BusinessProperties.IsValidAlteração = _business.Alterar(entity);
if (BusinessProperties.IsValidAlteração.ValidValue)
{
    _send.SendEmail(entity.Email, null, "alteração com sucesso", "...", false);
    //Debug.WriteLine($"Alterado com sucesso!");
}

// Exclui um item no Repository.
BusinessProperties.IsValidExclusão = _business.Excluir(entity);
if (BusinessProperties.IsValidExclusão.ValidValue)
{
    _send.SendEmail(entity.Email, null, "exclusão com sucesso", "...", false);
    //Debug.WriteLine($"Exclusão com sucesso!");
}

// Retorna DataTable e exporta tabela.
DataTable dtIn = _business.ReturnDataTable(new Entity());

// Exporta Table para um novo arquivo.
BusinessProperties.IsValidExport = _business.ExportDataTable(dtIn, Directory.GetCurrentDirectory());
if (BusinessProperties.IsValidExclusão.ValidValue)
{
    _send.SendEmail(entity.Email, null, "exportado com sucesso", "...", false);
    //Debug.WriteLine($"Exclusão com sucesso!");
}

DataTable dtOut = _business.ImportDataTable(Directory.GetCurrentDirectory());

#endregion

#region "Console"
Console.Read();
#endregion