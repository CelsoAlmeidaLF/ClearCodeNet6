using Systekna.Application;
using Systekna.Core;
using Systekna.Core.Entity;
using System.Diagnostics;

Console.Title = "Console Test CRUD";

// Entidades do negócio.
Entity entity = new Entity();

// Chama regra de negócio.
IBusiness<Entity> _business = new BusinessOffice();
IlogEvent log = new Log();

#region "Methods basic CRUD"

//entity = new Entity() { DataCriação = DateTime.Now, ID = 402 };
entity.Valid = _business.InsertRepository(entity);
Debug.WriteLine((entity.GetValid ? $"ID: {entity.ID} cadastrado em: {entity.DataCriação}." : "não cadastrado ..."));

//entity = new Entity() { DataAlteração = DateTime.Now, ID = 404 };
entity.Valid = _business.UpdateRepository(entity);
Debug.WriteLine((entity.GetValid ? $"ID: {entity.ID} alterado em: {entity.DataAlteração}." : "não alterado ..."));

//entity = new Entity() { DataExclusão = DateTime.Now, ID = 405 };
entity.Valid = _business.DeleteRepository(entity);
Debug.WriteLine((entity.GetValid ? $"ID: {entity.ID} removido em: {entity.DataExclusão}." : "não removido ..."));

#endregion
