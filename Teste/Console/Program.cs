using Systekna.Application;
using Systekna.Core;
using Systekna.Core.Entity;
using System.Diagnostics;

Console.Title = "Console Test CRUD";

// Chama regra de negócio.
IBusiness<Entity> _business = new BusinessOffice();
IlogEvent log = new Log();

Console.WriteLine("Name: " + _business.GetType().Name);
Console.WriteLine("Assembly: " + _business.GetType().Assembly);
Console.ReadKey();

Debug.WriteLine("--> INICIO ");


Debug.WriteLine("--> FIM ");
