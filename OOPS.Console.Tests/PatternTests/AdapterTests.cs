using System.Collections.Generic;
using NUnit.Framework;
using OOPS.Console.Patterns.Adapter;

namespace OOPS.Console.Tests.PatternTests
{
    [TestFixture]
    public class AdapterTests
    {
        [Test]
        public void InitializeAdapterTestClient()
        {
            List<IMessagingAdapter> adapters = new List<IMessagingAdapter>();
            adapters.Add(new EmailMessagingAdapter(new EmailService()));
            adapters.Add(new MessageMessagingAdapter(new MessagingService()));

            List<InboxMessage> inboxMessages = new List<InboxMessage>();

            foreach (var adapter in adapters)
            {
                inboxMessages.AddRange(adapter.GetContextMessages());
            }
        }
    }
}