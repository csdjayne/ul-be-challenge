namespace UL.BackendChallenge.Tests
{
    using System.Numerics;
    
    class FactorialTests
    {
        [Test]
        public void GivenNegativeNumber_ThenItShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => Factorial.Calculate(-1));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void GivenZeroOrOne_ThenItShouldReturnZero(int input)
        {
            var result = Factorial.Calculate(input);

            Assert.That(result, Is.EqualTo(expected: new BigInteger(1)));
        }

        [TestCase(4, 24)]
        [TestCase(9, 362_880)]
        [TestCase(20, 2432902008176640000)]
        public void GivenValidNumber_ThenItShouldReturnFactorial(int input, long expected)
        {
            var result = Factorial.Calculate(input);

            Assert.That(result, Is.EqualTo(new BigInteger(expected)));
        }

        [Test]
        public void GivenVeryLargeNumber_ThenItShouldReturnFactorial()
        {
            var result = Factorial.Calculate(21);

            Assert.That(result.ToString(), Is.EqualTo("51090942171709440000"));
        }
    }
}