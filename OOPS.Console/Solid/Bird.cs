using System.Diagnostics;

namespace OOPS.Console.Solid
{

    public class Bird
    {
        // Base class with no fly method
    }

    interface IFlyingBird
    {
        void Fly();
    }

    class Sparrow : IFlyingBird
    {
        public void Fly()
        {
            // Flying behavior specific to sparrows
        }
    }

    public class Ostrich : Bird
    {
        // Ostrich-specific behavior
        public void Run()
        {
            Debug.WriteLine("An ostrich can run.");
        }
    }

}