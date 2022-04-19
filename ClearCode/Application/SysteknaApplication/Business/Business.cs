
using Systekna.Application.Interface;
using Systekna.Core.Entity;
using Systekna.Core.Valid;
using Systekna.Infrastructure;
using Systekna.Infrastructure.File;
using Systekna.Infrastructure.Interface;
using System;
using System.Data;

namespace Systekna.Application
{
    public class Business : IBusiness<Entity>, IBusinessConsulta<Entity>, IBusinessImport
    {
        public IExcel excel;

        public static Valid IsValidCadastro { get; set; }
        public static Valid IsValidAlteração { get; set; }
        public static Valid IsValidExclusão { get; set; }
        public static Valid IsValidExport{ get; set; }

        public Valid Alterar(Entity entity)
        {
            entity.DataAlteração = DateTime.Now;
            entity.ID = 100;

            return new Valid()
            {
                ValidValue = new Repository(Framework.StringConection).Alterar(entity),
                StringMethod = System.Reflection.MethodBase.GetCurrentMethod().Name
            };
        }
        public Valid Cadastrar(Entity entity)
        {
            entity.DataCriação = DateTime.Now;
            entity.ID = 404;

            return new Valid() { 
                ValidValue = new Repository(Framework.StringConection).Cadastrar(entity),
                StringMethod = System.Reflection.MethodBase.GetCurrentMethod().Name
            };
        }
        public Valid Excluir(Entity entity)
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
        public DataTable ImportDataTable(string path)
        {
            excel = new Excel();
            return excel.Import(path);
        }
    }
}