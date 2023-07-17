using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OOPS.Console.Patterns.Singleton;

namespace OOPS.Console.Tests.PatternTests
{
    [TestFixture]
    public class SingletonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSingletonInstance()
        {
            var instance = SingletonPattern.Instance;
            Debug.WriteLine(instance);


            for (int i = 0; i < 8; i++)
            {
                var randomInstance = SingletonPattern.Instance;
                Debug.WriteLine(randomInstance);
            }
        }
        
        [Test]
        public void TestSingletonInstanceThreadSafety()
        {
            Parallel.For(0, 100, i =>
            {
                // Get the Singleton instance.
                var singletonString = SingletonPattern.Instance;

                // Print a message to the console indicating the thread ID and the hash code of the Singleton instance.
                Debug.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}, Singleton hash code: {singletonString.GetHashCode()}");
            });
        }
    }
}