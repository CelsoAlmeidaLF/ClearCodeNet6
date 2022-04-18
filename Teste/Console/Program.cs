
using Systekna.Application;
using Systekna.Application.Interface;
using Systekna.Core.Entity;
using System.Diagnostics;

Entity entity = new Entity();
IBusiness<Entity> business = new Business();

Console.WriteLine("Name: " + entity.GetType().Name);
Console.WriteLine("Assembly: " + entity.GetType().Assembly);
Console.WriteLine("Name: " + business.GetType().Name);
Console.WriteLine("Assembly: " + business.GetType().Assembly);

Business.IsValidCadastro = business.Cadastrar(entity);
if (Business.IsValidCadastro.ValidValue)
{
    Debug.WriteLine($"Cadastrado com sucesso!");
}

Business.IsValidAlteração = business.Alterar(entity);
if (Business.IsValidAlteração.ValidValue)
{
    Debug.WriteLine($"Alterado com sucesso!");
}

Business.IsValidExclusão = business.Excluir(entity);
if (Business.IsValidExclusão.ValidValue)
{
    Debug.WriteLine($"Exclusão com sucesso!");
}

Console.Read();