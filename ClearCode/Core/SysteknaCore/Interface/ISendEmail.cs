namespace Systekna.Core.Interface
{
    public interface ISendEmail
    {
        public bool? SendEmail(string cc, string co, string assunto, string corpo, bool? html);
    }
}