using System;

namespace Systekna.Core
{
    public class EntityUser
    {
        public string NameUserLogin { get { return Environment.UserName;  } }
        public DateTime DataUserLogin { get { return DateTime.Now; } }
        public string Email { get; set; }
    }
}