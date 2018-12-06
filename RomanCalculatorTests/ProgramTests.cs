using NUnit.Framework;

namespace RomanCalculator.Tests
{
    class ProgramTests
    {
        [Test]
        public void Adding_two_empty_numbers_returns_an_empty_sum()
        {
            var firstNumber = "";
            var secondNumber = "";

            var actualSum = firstNumber + secondNumber;

            Assert.AreEqual("", actualSum);
        }

        [Test]
        public void Adding_an_empty_number_to_a_non_empty_number_returns_the_non_empty_number() {
            var nonEmptyNumber = "I";
            var emptyNumber = "";

            var actualSum = nonEmptyNumber + emptyNumber;

            Assert.AreEqual(nonEmptyNumber, actualSum);
        }

        [Test]
        public void Adding_a_non_empty_number_to_an_empty_number_returns_the_non_empty_number()
        {
            var emptyNumber = "";
            var nonEmptyNumber = "I";

            var actualSum = emptyNumber + nonEmptyNumber;

            Assert.AreEqual(nonEmptyNumber, actualSum);
        }

    }
}
