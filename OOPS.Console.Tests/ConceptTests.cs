using NUnit.Framework;
using OOPS.Console.Concepts;
using OOPS.Console.Concepts.Delegates;
using OOPS.Console.Concepts.Delegates.DelegateAndEvent;
using OOPS.Console.Concepts.Delegates.Multicast;
using OOPS.Console.Concepts.Delegates.MultipleDelegates;
using OOPS.Console.Concepts.Delegates.OrderDelegates;
using OOPS.Console.Concepts.Lambdas;

namespace OOPS.Console.Tests
{
    public class ConceptTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStaticConstructor()
        {
            for (int i = 0; i < 8; i++)
            {
                StaticConstructors instance = new StaticConstructors();
            }

            var value = StaticConstructors.GetCount();
        }

        [Test]
        public void TestPrivateConstructor()
        {
            PrivateConstructors.CreateInstance();
            var _pv = PrivateConstructors.Instance;
        }
        
        [Test]
        public void TestDelegateCallback()
        {
            Calculator calculator = new Calculator();
            PrintResult result = new PrintResult();
            calculator.Add(10,2, result.Print);
        }
        
        [Test]
        public void TestOrderDelegate()
        {
            OrderCaller caller = new OrderCaller();
        }

        [Test]
        public void MultipleDelegateTest()
        {
            Consumers.Consumer1 consumer1 = new Consumers.Consumer1();
            Consumers.Consumer2 consumer2 = new Consumers.Consumer2();

            // Create an instance of the delegate and add the consumer methods to it
            Consumers.ThreeParameterDelegate delegateInstance = new Consumers.ThreeParameterDelegate(consumer1.Method1);
            delegateInstance += consumer2.Method2;

            // Call the delegate, passing in the required parameters
            int result = delegateInstance.Invoke(1, 2, 3);

            System.Console.WriteLine("Result: " + result); // Output: Result: 9 (from consumer1.Method1)
        }

        [Test]
        public void MultipleDelegateTest2()
        {
            var demo = new DelegateNEventCallerClass();
        }

        [Test]
        public void TestMulticastDelegate()
        {
            var example = new MulticastExample();
        }

        [Test]
        public void EventSubscriberTest()
        {
            var sub = new Subscriber();
            
        }
    }
}