using System;

namespace Systekna.Core
{
    public class EntityUser
    {
        public string UserNameLogin { get; } = Environment.UserName;
        public DateTime DataLogin { get; } = DateTime.Now;
    }
}