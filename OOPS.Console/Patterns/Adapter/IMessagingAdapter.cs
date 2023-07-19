using System.Collections.Generic;

namespace OOPS.Console.Patterns.Adapter
{
    public interface IMessagingAdapter
    {
        List<InboxMessage> GetContextMessages();
    }
}