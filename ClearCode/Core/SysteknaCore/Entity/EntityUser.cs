using System;

namespace Systekna.Core
{
    public class EntityUser
    {
        public string NameUserLogin { get; } = Environment.UserName;
        public DateTime DataUserLogin { get; } = DateTime.Now;
        public string Email { get; } = "celso.almeida.leite@hotmail.com";
    }
}