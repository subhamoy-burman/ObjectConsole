using System.Collections.Generic;

namespace OOPS.Console.Patterns.Adapter
{
    public class MessageMessagingAdapter : IMessagingAdapter
    {
        private IMessagingService _messagingService;
        public MessageMessagingAdapter(IMessagingService messagingService)
        {
            _messagingService = messagingService;
        }
        
        public List<InboxMessage> GetContextMessages()
        {
            var messages = _messagingService.GetMessages();
            
            List<InboxMessage> allMessages = new List<InboxMessage>();

            foreach (var item in messages)
            {
                allMessages.Add(new InboxMessage($" Message From messaging Subject: {item.Subject} with content {item.Body}"));
            }

            return allMessages;
        }
    }
}