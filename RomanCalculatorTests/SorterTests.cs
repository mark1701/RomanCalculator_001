using NUnit.Framework;

namespace RomanCalculator.Tests
{
    [TestFixture]
    internal class SorterTests
    {
        [Test]
        public void Sorting_by_numeral_weights_a_positivised_number() {
            //output: a string containing all occuring numerals sorted by weight
            //a roman number in positive notation
            var input = "VIIIILXXXXI";
            var expectedSortedNumber = "LXXXXVIIIII";

            var sortedByWeightNumerals = new char[] { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            var result = "";

            foreach (var numeral in sortedByWeightNumerals)
            {
                foreach (char element in input) {
                    if (element == numeral) {
                        result += numeral;
                    }
                }
            }

            Assert.AreEqual(expectedSortedNumber, result);
        }
    }
}
