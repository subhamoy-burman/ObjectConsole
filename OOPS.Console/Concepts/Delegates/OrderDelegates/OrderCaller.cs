namespace OOPS.Console.Concepts.Delegates.OrderDelegates
{
    public class OrderCaller
    {
        public OrderCaller()
        {
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.OrderInitialized = PrintMessage;
            orderProcessor.OrderInitializor();
        }

        public void PrintMessage()
        {
            System.Console.WriteLine("Calling Order");
        }
    }
}