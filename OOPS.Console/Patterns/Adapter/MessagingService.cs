using System.Collections.Generic;

namespace OOPS.Console.Patterns.Adapter
{
    public class MessagingService : IMessagingService
    {
        public List<MessageModel> GetMessages()
        {
            return new List<MessageModel>()
            {
                new MessageModel("Message1", "Welcome"),
                new MessageModel("Message2", "Welcome 2")
            };
        }
    }
}