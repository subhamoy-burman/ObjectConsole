namespace OOPS.Console.Patterns.Factory
{
    public class Transport
    {
        private ITransport _transport;
        public Transport(ITransport transport)
        {
            _transport = transport;
        }

        public void PerformDelivery()
        {
            _transport.Delivery();
        }
    }
}