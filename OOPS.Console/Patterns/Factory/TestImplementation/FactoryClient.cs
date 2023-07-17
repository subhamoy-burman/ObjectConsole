namespace OOPS.Console.Patterns.Factory
{
    public class FactoryClient
    {
        public FactoryClient()
        {
            var roadTransport = new RoadTransport();
            var transport = new Transport(roadTransport);
            transport.PerformDelivery();
        }
    }
}