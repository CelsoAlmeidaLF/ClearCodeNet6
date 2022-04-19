
using Systekna.Application;
using Systekna.Application.Interface;
using Systekna.Core.Entity;
using System.Data;

Console.Title = "Console Test CRUD";

// Entidades do negócio.
Entity entity = new Entity();

// Chama regra de negócio.
IBusiness<Entity> _business = new Business();
ISendEmail _send = new BusinessEmail();
IBusinessConsulta<Entity> _bConsulta = new Business();

// Cadastra um item no Repository.
Business.IsValidCadastro = _business.Cadastrar(entity);
if (Business.IsValidCadastro.ValidValue)
{
    _send.SendEmail(entity.Email, null, "cadastro com sucesso", "...", false);
    //Debug.WriteLine($"Cadastrado com sucesso!");
}

// Altera um item no Repository.
Business.IsValidAlteração = _business.Alterar(entity);
if (Business.IsValidAlteração.ValidValue)
{
    _send.SendEmail(entity.Email, null, "alteração com sucesso", "...", false);
    //Debug.WriteLine($"Alterado com sucesso!");
}

// Exclui um item no Repository.
Business.IsValidExclusão = _business.Excluir(entity);
if (Business.IsValidExclusão.ValidValue)
{
    _send.SendEmail(entity.Email, null, "exclusão com sucesso", "...", false);
    //Debug.WriteLine($"Exclusão com sucesso!");
}

// Retorna DataTable e exporta tabela.
DataTable dt = _bConsulta.ReturnDataTable(new Entity());

Business.IsValidExport = _bConsulta.ExportDataTable(dt, Directory.GetCurrentDirectory());
if (Business.IsValidExclusão.ValidValue)
{
    _send.SendEmail(entity.Email, null, "exportado com sucesso", "...", false);
    //Debug.WriteLine($"Exclusão com sucesso!");
}

#region "Console"
Console.WriteLine("Name: " + entity.GetType().Name);
Console.WriteLine("Assembly: " + entity.GetType().Assembly);
Console.WriteLine("Name: " + _business.GetType().Name);
Console.WriteLine("Assembly: " + _business.GetType().Assembly);
Console.Read();
#endregion