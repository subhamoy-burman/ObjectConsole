using System.Diagnostics;

namespace OOPS.Console.Concepts.Delegates.DelegateAndEvent
{
    public class DelegateNEventCallerClass
    {
        
        public DelegateNEventCallerClass()
        {
            var demo = new DelegateNEventClass();
            demo.InvokeDelegate(Print,6);

            demo.DemoEvent += Print;
            demo.DemoEvent += Print1;
            demo.DemoEvent += Print2;
            demo.DemoEvent += Print3;

            demo.InvokeEvent(8);
        }

        public void Print(int m)
        {
            Debug.WriteLine($"Printing {m}");
        }
        
        public void Print1(int m)
        {
            Debug.WriteLine($"Printing 1 {m}");
        }
        
        public void Print2(int m)
        {
            Debug.WriteLine($"Printing 2 {m}");
        }
        
        public void Print3(int m)
        {
            Debug.WriteLine($"Printing 3 {m}");
        }
    }
}