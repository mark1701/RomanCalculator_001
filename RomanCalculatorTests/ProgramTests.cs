using NUnit.Framework;

namespace RomanCalculator.Tests
{
    class ProgramTests
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

    }
}
