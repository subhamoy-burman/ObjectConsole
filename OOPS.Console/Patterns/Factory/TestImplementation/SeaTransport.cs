using System.Diagnostics;

namespace OOPS.Console.Patterns.Factory
{
    public class SeaTransport: ITransport
    {
        public void Delivery()
        {
            Debug.WriteLine("Delivering through sea");
        }
    }
}