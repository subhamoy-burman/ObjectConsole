using System.Diagnostics;
using System.Net.Mime;

namespace OOPS.Console.Concepts.Delegates.Multicast
{
    public delegate void OrderCompletedDelegate();
    public class MulticastExample
    {
        private OrderCompletedDelegate _orderCompletedDelegate = null;

        public MulticastExample()
        {
            _orderCompletedDelegate += new OrderCompletedDelegate(MethodA);
            _orderCompletedDelegate += new OrderCompletedDelegate(MethodB);
            _orderCompletedDelegate += new OrderCompletedDelegate(MethodB);

            _orderCompletedDelegate.Invoke();
            
        }
        
        public void MethodA()
        {
            Debug.WriteLine("Method A");
        }
        
        public void MethodB()
        {
            Debug.WriteLine("Method B");
        }
        
        
        public void MethodC()
        {
            Debug.WriteLine("Method C");
        }
    }
    
    
}