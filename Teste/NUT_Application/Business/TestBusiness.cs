using NUnit.Framework;
using Systekna.Core.Entity;
using System;
using System.Diagnostics;

namespace Systekna.Application.NUnit
{
    public class BusinessTest
    {
        // Chama regra de neg�cio.
        private IBusiness<Entity> _business;

        [SetUp]
        public void Setup()
        {
            _business = new BusinessOffice();
        }

        [Test]
        public void TestInsert()
        {
            Entity entity = new Entity();
            entity = new Entity() { DataCria��o = DateTime.Now, ID = 402 };
            entity.Valid = _business.InsertRepository(entity);

            Debug.WriteLine((entity.GetValid ? $"ID: {entity.ID} cadastrado em: {entity.DataCria��o}." : "n�o cadastrado ..."));
            Assert.IsTrue(entity.GetValid);
        }

        [Test]
        public void TestUpdate()
        {
            Entity entity = new Entity();
            entity = new Entity() { DataAltera��o = DateTime.Now, ID = 404 };
            entity.Valid = _business.UpdateRepository(entity);

            Debug.WriteLine((entity.GetValid ? $"ID: {entity.ID} alterado em: {entity.DataAltera��o}." : "n�o alterado ..."));
            Assert.IsTrue(entity.GetValid);
        }

        [Test]
        public void TestDelete()
        {
            Entity entity = new Entity();
            entity = new Entity() { DataExclus�o = DateTime.Now, ID = 405 };
            entity.Valid = _business.DeleteRepository(entity);

            Debug.WriteLine((entity.GetValid ? $"ID: {entity.ID} removido em: {entity.DataExclus�o}." : "n�o removido ..."));
            Assert.IsTrue(entity.GetValid);
        }
    }
}