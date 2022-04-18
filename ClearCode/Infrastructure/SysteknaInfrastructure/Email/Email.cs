using Systekna.Infrastructure.Interface;

namespace Systekna.Infrastructure.Email
{
    public class Email : IEmail
    {
        public bool? SendEmail(string cc, string co, string assunto, string corpo, bool? html)
        {
            return null;
        }
    }
}
