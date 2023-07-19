using System.Collections.Generic;

namespace OOPS.Console.Patterns.Adapter
{
    public class EmailMessagingAdapter : IMessagingAdapter
    {
        private IEmailService _emailService;
        public EmailMessagingAdapter(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public List<InboxMessage> GetContextMessages()
        {
           var emails = _emailService.GetEmails();
           List<InboxMessage> allMessages = new List<InboxMessage>();

           foreach (var item in emails)
           {
               allMessages.Add(new InboxMessage($" Message Subject from emails: {item.Subject} with content {item.Body}"));
           }

           return allMessages;
        }
    }
}