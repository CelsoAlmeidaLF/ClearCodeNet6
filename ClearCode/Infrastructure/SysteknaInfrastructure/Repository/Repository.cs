using Systekna.Core.Entity;
using System;

namespace Systekna.Infrastructure
{
    public class Repository
    {
        private string stringConection;

        public Repository(string stringConection)
        {
            this.stringConection = stringConection;
        }

        public bool Cadastrar(Entity entity)
        { 
            return entity.DataCriação != null ? true : false;
        }

        public bool Alterar(Entity entity)
        {
            return entity.DataAlteração != null ? true : false;
        }

        public bool Excluir(Entity entity)
        {
            return entity.DataExclusão != null ? true : false;
        }
    }
}