using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using OOPS.Console.Concepts;
using OOPS.Console.Concepts.AsyncAwaits;
using OOPS.Console.Concepts.Delegates;
using OOPS.Console.Concepts.Delegates.DelegateAndEvent;
using OOPS.Console.Concepts.Delegates.Events;
using OOPS.Console.Concepts.Delegates.FuncAndAction;
using OOPS.Console.Concepts.Delegates.Multicast;
using OOPS.Console.Concepts.Delegates.MultipleDelegates;
using OOPS.Console.Concepts.Delegates.OrderDelegates;
using OOPS.Console.Concepts.Delegates.OverloadingOverriding;
using OOPS.Console.Concepts.Lambdas;
using OOPS.Console.Solid;

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

        [Test]
        public void EventDelegateTest()
        {
            var calc = new CalculatorConsumer();
        }

        [Test]
        public void TestOrderConsumer()
        {
            var _order = new OrderEventConsumer();
            _order.sub.CreateOrder();
        }

        [Test]
        public void TestOperatorOverloading()
        {
            var v1 = new Vector2D(2, 3);
            var v2 = new Vector2D(5, 9);

            var sum = v1 + v2;
        }

        [Test]
        public void TestAsync()
        {
            var v1 = new AsyncAwait();
            v1.CallAsyncOperation();
        }
        
        [Test]
        public void TestAsync2()
        {
            var v1 = new AsyncAwait();
            v1.ButtonClickEventHandler(null,null);
        }

        [Test]
        public void TestLSP()
        {
            Bird ostrich = new Ostrich();
            //ostrich.
        }
        
        [Test]
        public async Task TestAsync3()
        {
            var v1 = new AsyncAwait();
            var numbers = new List<Task> {v1.ReturnFiveNumbers(), v1.ReturnThreeNumbers(), v1.ReturnTenNumbers()};
            await Task.WhenAll(numbers);
            List<int> concurrentList = new List<int>();
            foreach (var task in numbers)
            {
                await task;
            }
        }

        [Test]
        public void TestDelegates()
        {
            DelegateDemo demo = new DelegateDemo();
            DelegateDemo.MyDelegate myDelegate = new DelegateDemo.MyDelegate(demo.PrintMessage);
            
            myDelegate.Invoke("Printing general message");
        }
        
        [Test]
        public void TestDelegates2()
        {
            DelegateDemo demo = new DelegateDemo();
            DelegateDemo.MyDelegate myDelegate = demo.PrintMessage;

            myDelegate += demo.PrintMessageInUpperCase;
            
            myDelegate.Invoke("Convert this message to lower to upper");
        }
    }
}