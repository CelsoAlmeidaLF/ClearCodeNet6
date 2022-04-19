
using Systekna.Application;
using Systekna.Application.Interface;
using Systekna.Core.Entity;
using System.Data;

Console.Title = "Console Test CRUD";

// Entidades do negócio.
Entity entity = new Entity();

// Chama regra de negócio.
IBusiness<Entity> _bCadastraAtualizaRepository = new Business();
ISendEmail _send = new BusinessEmail();
IBusinessConsulta<Entity> _bConsultaRepository = new Business();
IBusinessImport _bImportDataTable = new Business();

#region "Methods"

// Cadastra um item no Repository.
Business.IsValidCadastro = _bCadastraAtualizaRepository.Cadastrar(entity);
if (Business.IsValidCadastro.ValidValue)
{
    _send.SendEmail(entity.Email, null, "cadastro com sucesso", "...", false);
    //Debug.WriteLine($"Cadastrado com sucesso!");
}

// Altera um item no Repository.
Business.IsValidAlteração = _bCadastraAtualizaRepository.Alterar(entity);
if (Business.IsValidAlteração.ValidValue)
{
    _send.SendEmail(entity.Email, null, "alteração com sucesso", "...", false);
    //Debug.WriteLine($"Alterado com sucesso!");
}

// Exclui um item no Repository.
Business.IsValidExclusão = _bCadastraAtualizaRepository.Excluir(entity);
if (Business.IsValidExclusão.ValidValue)
{
    _send.SendEmail(entity.Email, null, "exclusão com sucesso", "...", false);
    //Debug.WriteLine($"Exclusão com sucesso!");
}

// Retorna DataTable e exporta tabela.
DataTable dtIn = _bConsultaRepository.ReturnDataTable(new Entity());

// Exporta Table para um novo arquivo.
Business.IsValidExport = _bConsultaRepository.ExportDataTable(dtIn, Directory.GetCurrentDirectory());
if (Business.IsValidExclusão.ValidValue)
{
    _send.SendEmail(entity.Email, null, "exportado com sucesso", "...", false);
    //Debug.WriteLine($"Exclusão com sucesso!");
}

DataTable dtOut = _bImportDataTable.ImportDataTable(Directory.GetCurrentDirectory());

#endregion

#region "Console"
Console.Read();
#endregion