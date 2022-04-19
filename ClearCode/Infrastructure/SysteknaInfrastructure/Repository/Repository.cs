﻿using Systekna.Core.Entity;
using System;
using System.Data;

namespace Systekna.Infrastructure.Repository
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

        public DataTable Consultar(Entity entity)
        {
            return new DataTable("empty table");
        }
    }
}