using NUnit.Framework;
using OOPS.Console.Patterns.Factory.Implementation1;

namespace OOPS.Console.Tests.PatternTests
{
    [TestFixture]
    public class FacadeTests
    {
        [Test]
        public void FacadeTest1()
        {
            var knifeCreator = new KnifeCreator();
            knifeCreator.CreateWeapon().Sharpen();
        }
    }
}