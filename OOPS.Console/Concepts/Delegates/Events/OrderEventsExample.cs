using System;
using System.Diagnostics;

namespace OOPS.Console.Concepts.Delegates.Events
{
    public class OrderEventArgs
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
    }
    
    public class OrderEventsExample
    {
        public event EventHandler<OrderEventArgs> OrderCreatedEvent;

        public OrderEventsExample()
        {
        }

        public void CreateOrder()
        {
            Debug.WriteLine("Order being created");
            OrderEventArgs orderEventArgs = new OrderEventArgs();
            orderEventArgs.OrderId = 1;
            orderEventArgs.OrderName = "Event Name";
            OrderCreatedEvent?.Invoke(this, orderEventArgs);
        }
    }
}