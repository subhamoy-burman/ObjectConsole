namespace OOPS.Console.Concepts.Delegates.OrderDelegates
{
    public class OrderProcessor
    {
        public delegate void OrderInitializedDelegate();
        public delegate void OrderProcessedDelegate();

        public OrderInitializedDelegate OrderInitialized { get; set; }

        public void OrderInitializor()
        {
            OrderInitialized?.Invoke();
        }

        public void OrderProcesser(OrderProcessedDelegate orderProcess)
        {
            orderProcess.Invoke();
        }
        
    }
}