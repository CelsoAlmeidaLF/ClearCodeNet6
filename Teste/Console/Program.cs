
using Systekna.Application.Business;
using Systekna.Application.Interface;
using Systekna.Core.Entity;
using Systekna.Core.Valid;
using System.Data;

EntityBusiness entity = new EntityBusiness();
DataTable data = new DataTable();
IBusiness<EntityBusiness> business = new Business();

try
{
    EntityBusiness.IsValid(entity);
    data = IsValid.Value.Equals(true) ? business.GetDataTable(entity) : throw new Exception("Parametro não encontrado!");
    bool? complet = business.IsComplet();
}
catch (Exception ex)
{
    Console.Error.WriteLine(ex.Message);
}