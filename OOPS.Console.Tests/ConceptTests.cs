using NUnit.Framework;
using OOPS.Console.Concepts;

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
    }
}