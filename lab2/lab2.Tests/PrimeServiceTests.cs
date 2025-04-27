using NUnit.Framework;

namespace lab2.Tests
{
    [TestFixture]
    public class PrimeServiceTests
    {
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(17, true)]
        [TestCase(18, false)]
        [TestCase(19, true)]
        [TestCase(20, false)]
        [TestCase(1, false)]
        [TestCase(0, false)]
        [TestCase(-5, false)]
        public void IsPrime_Tests(int number, bool expected)
        {
            bool result = PrimeService.IsPrime(number);
            Assert.AreEqual(expected, result);
        }
    }
}