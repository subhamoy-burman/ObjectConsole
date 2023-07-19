using System.Collections.Generic;

namespace OOPS.Console.Patterns.Adapter
{
    public interface IEmailService
    {
        List<EmailModel> GetEmails();
    }
}