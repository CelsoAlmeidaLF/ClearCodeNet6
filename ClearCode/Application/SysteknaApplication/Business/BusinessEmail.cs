using System.Diagnostics;

namespace Systekna.Application
{
    public class BusinessEmail : ISendEmail
    {
        public bool? SendEmail(string cc, string co, string assunto, string corpo, bool? html)
        {
            Debug.WriteLine($"O email foi enviado para: {cc}...");
            return true;
        }
    }
}