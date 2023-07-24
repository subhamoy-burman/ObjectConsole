using NUnit.Framework;
using OOPS.Console.Concepts;
using OOPS.Console.Concepts.Delegates;

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
    }
}