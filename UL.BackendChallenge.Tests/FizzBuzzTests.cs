namespace UL.BackendChallenge.Tests
{
    class FizzBuzzTests
    {
        [Test]
        public void GivenInputOfZero_ReturnEmptyList()
        {
            var result = FizzBuzz.Generate(0);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GivenInputOfTwo_ReturnNumbersOnly()
        {
            var result = FizzBuzz.Generate(2);

            var expected = new string[] { "1", "2" };

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenInputOfThree_ReturnFizzCorrectly()
        {
            var result = FizzBuzz.Generate(3);

            var expected = new string[] { "1", "2", "Fizz" };

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenInputOfFive_ReturnBuzzCorrectly()
        {
            var result = FizzBuzz.Generate(5);

            var expected = new string[] { "1", "2", "Fizz", "4", "Buzz" };

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenInputOfFifteen_ReturnFizzBuzzCorrectly()
        {
            var result = FizzBuzz.Generate(15);

            var expected = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
