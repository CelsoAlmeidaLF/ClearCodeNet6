using NUnit.Framework;
using Systekna.Core.Entity;
using System;
using System.Diagnostics;

namespace Systekna.Application.NUnit
{
    public class BusinessTest
    {
        // Chama regra de negócio.
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
            entity = new Entity() { DataCriação = DateTime.Now, ID = 402 };
            entity.Valid = _business.InsertRepository(entity);

            Debug.WriteLine((entity.GetValid ? $"ID: {entity.ID} cadastrado em: {entity.DataCriação}." : "não cadastrado ..."));
            Assert.IsTrue(entity.GetValid);
        }

        [Test]
        public void TestUpdate()
        {
            Entity entity = new Entity();
            entity = new Entity() { DataAlteração = DateTime.Now, ID = 404 };
            entity.Valid = _business.UpdateRepository(entity);

            Debug.WriteLine((entity.GetValid ? $"ID: {entity.ID} alterado em: {entity.DataAlteração}." : "não alterado ..."));
            Assert.IsTrue(entity.GetValid);
        }

        [Test]
        public void TestDelete()
        {
            Entity entity = new Entity();
            entity = new Entity() { DataExclusão = DateTime.Now, ID = 405 };
            entity.Valid = _business.DeleteRepository(entity);

            Debug.WriteLine((entity.GetValid ? $"ID: {entity.ID} removido em: {entity.DataExclusão}." : "não removido ..."));
            Assert.IsTrue(entity.GetValid);
        }
    }
}