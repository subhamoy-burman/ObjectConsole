namespace OOPS.Console.Concepts.Delegates.DelegateAndEvent
{
    public class DelegateNEventClass
    {
        public delegate void DemoDelegate(int x);

        public event DemoDelegate DemoEvent;

        public void InvokeDelegate(DemoDelegate demoDelegate, int x)
        {
            demoDelegate.Invoke(x);
        }

        public void InvokeEvent(int x)
        {
            DemoEvent?.Invoke(x);
        }
    }
}