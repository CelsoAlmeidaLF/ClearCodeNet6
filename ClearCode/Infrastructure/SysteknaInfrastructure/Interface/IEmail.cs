namespace Systekna.Infrastructure.Interface
{
    public interface IEmail
    {
        public bool? SendEmail(string cc, string co, string assunto, string corpo, bool? html);
    }
}