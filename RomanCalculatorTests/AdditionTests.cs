using NUnit.Framework;

namespace RomanCalculator.Tests
{
    class AdditionTests
    {
        [Test]
        public void Adding_two_empty_numbers_returns_an_empty_sum()
        {
            var emptyNumber = "";
            var result = Addition.Sum(emptyNumber, emptyNumber);

            Assert.AreEqual(emptyNumber, result);
        }

        [Test]
        public void Adding_an_empty_number_to_a_non_empty_number_returns_the_non_empty_number() {
            var nonEmptyNumber = "I";
            var emptyNumber = "";

            var result = Addition.Sum(nonEmptyNumber,emptyNumber);

            Assert.AreEqual(nonEmptyNumber, result);
        }

        [Test]
        public void Adding_a_non_empty_number_to_an_empty_number_returns_the_non_empty_number()
        {
            var emptyNumber = "";
            var nonEmptyNumber = "I";

            var result = Addition.Sum(emptyNumber, nonEmptyNumber);

            Assert.AreEqual(nonEmptyNumber, result);
        }

        [Test]
        public void Adding_two_random_numbers()
        {
            var firstNumber = "IIII";
            var secondNumber = "XII";
            var expectedResult = "XVI";

            var result = Addition.Sum(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
