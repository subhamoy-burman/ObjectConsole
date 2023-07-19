using System.Collections.Generic;

namespace OOPS.Console.Patterns.Adapter
{
    public interface IMessagingService
    {
        List<MessageModel> GetMessages();
    }
}