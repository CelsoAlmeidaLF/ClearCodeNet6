using Systekna.Core.Interface;
using System.Diagnostics;

namespace Systekna.Application
{
    public class Email : ISendEmail
    {
        public bool? SendEmail(string cc, string co, string assunto, string corpo, bool? html)
        {
            Debug.WriteLine($"O email foi enviado para: {cc}...");
            Debug.WriteLine($"Assunto: {assunto}...");
            return true;
        }
    }
}