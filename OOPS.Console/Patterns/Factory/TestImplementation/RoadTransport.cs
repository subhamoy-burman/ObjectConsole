using System.Diagnostics;

namespace OOPS.Console.Patterns.Factory
{
    public class RoadTransport : ITransport
    {
        public void Delivery()
        {
            Debug.WriteLine("Delivering through road");
        }
    }
}