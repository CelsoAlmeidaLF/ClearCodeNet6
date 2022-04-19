
using Systekna.Application.Interface;
using Systekna.Core.Entity;
using Systekna.Core.Valid;
using Systekna.Infrastructure;
using System;

namespace Systekna.Application
{
    public class Business : IBusiness<Entity>
    {
        public static Valid IsValidCadastro { get; set; }
        public static Valid IsValidAlteração { get; set; }
        public static Valid IsValidExclusão { get; set; }

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
    }
}