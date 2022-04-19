﻿
using Systekna.Core.Entity;
using Systekna.Core.Valid;
using Systekna.Infrastructure;
using Systekna.Infrastructure.File;
using Systekna.Infrastructure.Repository;

using System;
using System.Data;

namespace Systekna.Application
{
    public partial class Business : IBusiness<Entity>
    {
        public IExcel excel;

        public Valid UpdateRepository(Entity entity)
        {
            entity.DataAlteração = DateTime.Now;
            entity.ID = 100;

            return new Valid()
            {
                ValidValue = new Repository(Framework.StringConection).Alterar(entity),
                StringMethod = System.Reflection.MethodBase.GetCurrentMethod().Name
            };
        }
        public Valid InsertRepository(Entity entity)
        {
            entity.DataCriação = DateTime.Now;
            entity.ID = 404;

            return new Valid() { 
                ValidValue = new Repository(Framework.StringConection).Cadastrar(entity),
                StringMethod = System.Reflection.MethodBase.GetCurrentMethod().Name
            };
        }
        public Valid DeleteRepository(Entity entity)
        {
            entity.DataExclusão = DateTime.Now;
            entity.Exclusão = true;

            return new Valid() 
            { 
                ValidValue = new Repository(Framework.StringConection).Excluir(entity),
                StringMethod = System.Reflection.MethodBase.GetCurrentMethod().Name
            };
        }
        public Valid ExportDataTable(DataTable data, string path)
        {
            excel = new Excel();
            return new Valid()
            {
                ValidValue = excel.Export(data, path),
                StringMethod = System.Reflection.MethodBase.GetCurrentMethod().Name
            };
        }
        public DataTable ReturnDataTable(Entity entity)
        {
            return new Repository(Framework.StringConection).Consultar(entity);
        }
        public DataTable ImportDataFile(string path)
        {
            excel = new Excel();
            return excel.ImportDataFile(path);
        }
    }
}