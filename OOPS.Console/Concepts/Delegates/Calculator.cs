namespace OOPS.Console.Concepts.Delegates
{
    public class Calculator
    {
        public delegate void MethodOperation(int result);
        public void Add(int a, int b, MethodOperation callBack)
        {
            callBack(a + b);
        }
    }
}