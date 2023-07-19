using System.Collections.Generic;

namespace OOPS.Console.Patterns.Adapter
{
    public class EmailService : IEmailService
    {
        public List<EmailModel> GetEmails()
        {
            return new List<EmailModel>()
            {
                new EmailModel("Email 1", "Email Details 1"),
                new EmailModel("Email 2", "Email Details 2")
            };

        }
    }
}