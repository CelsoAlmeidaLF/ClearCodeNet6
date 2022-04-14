using NUnit.Framework;
using Systekna;
using Systekna.Application.Business;
using Systekna.Application.Interface;
using Systekna.Core.Entity;
using System;
using System.Data;

namespace NUT.Application
{
    public class TestsBusiness
    {
        public IBusiness<EntityBusiness> _business;

        [SetUp]
        public void Setup()
        {
            Framework.StringConection = @"";
            _business = new Business();
        }

        [Test]
        public void TestGetDataTableNull()
        {
            DataTable data = _business.GetDataTable(null);
            
            // regra:
            // O parametro deve ser null!
            // 1. A tabela retornou vazia?
            // 2. IsComplet é false?
            Assert.IsFalse(_business.IsComplet());
            Assert.IsNull(data);
        }

        [Test]
        public void TestGetDataTableNotNull()
        {
            EntityBusiness entity = new EntityBusiness();
            DataTable data = _business.GetDataTable(entity);
            
            // regra:
            // 1. A passagem de parametro deve ser "diferente de null"!
            // 2. A tabela é null ?
            // 3. O processo está completo?
            // 4. A tabela é diferente de vazia?
            // 5. Ela recebeu o apelido?
            Assert.IsNotNull(data);
            Assert.IsTrue(_business.IsComplet());
            Assert.IsTrue(data.Rows.Count > 0);
            Assert.IsTrue(data.TableName.Equals("TB_DESPESA"));

        }
    }
}