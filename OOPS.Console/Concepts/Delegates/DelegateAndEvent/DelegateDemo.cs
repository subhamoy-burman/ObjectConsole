using System.Diagnostics;

namespace OOPS.Console.Concepts.Delegates.DelegateAndEvent
{
    public class DelegateDemo
    {
        public delegate void MyDelegate(string message);
        
        public  void PrintMessage(string message)
        {
            Debug.WriteLine(message);
        }

        public void PrintMessageInUpperCase(string message)
        {
            Debug.WriteLine(message.ToUpper());
        }

    }
}