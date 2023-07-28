namespace OOPS.Console.Concepts.Delegates.MultipleDelegates
{
    public class Consumers
    {
        public delegate int ThreeParameterDelegate(int a, int b, int c);

        public class Consumer1
        {
            public int Method1(int a, int b, int c)
            {
                // Perform some work with the parameters...
                return a + b + c;
            }
        }

        public class Consumer2
        {
            public int Method2(int a, int b, int c)
            {
                // Perform some other work with the parameters...
                return a * b * c;
            }
        }
    }
}