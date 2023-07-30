using System.Diagnostics;

namespace OOPS.Console.Concepts.Delegates.Events
{
    public class OrderEventConsumer
    {
        public OrderEventsExample sub;
        public OrderEventConsumer()
        {
            sub = new OrderEventsExample();
            sub.OrderCreatedEvent+= SubOnOrderCreatedEvent;
        }

        public void SubOnOrderCreatedEvent(object sender, OrderEventArgs e)
        {
            Debug.WriteLine("Created Order now we can serve it.");
        }
    }
}