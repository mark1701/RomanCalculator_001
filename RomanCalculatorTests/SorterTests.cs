using NUnit.Framework;
using System.Collections;

namespace RomanCalculator.Tests
{
    [TestFixture]
    internal class SorterTests
    {
        [Test, TestCaseSource(typeof(SorterTestData), nameof(SorterTestData.UnsortedCases))]
        public string Sorting_by_weights_a_positivised_number(string numberToSort) {
            var sortedByWeightNumerals = new char[] { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            var sortedNumber = "";

            foreach (var numeral in sortedByWeightNumerals)
            {
                foreach (char element in numberToSort) {
                    if (element == numeral) {
                        sortedNumber += numeral;
                    }
                }
            }

            return sortedNumber;
        }

        private class SorterTestData
        {
            public static IEnumerable UnsortedCases
            {
                get
                {
                    yield return new TestCaseData("").Returns("");
                    yield return new TestCaseData("X").Returns("X");
                    yield return new TestCaseData("III").Returns("III");
                    yield return new TestCaseData("IDLCCXILM").Returns("MDCCLLXII");
                    yield return new TestCaseData("VXVIIII").Returns("XVVIIII");
                    yield return new TestCaseData("XXXXVIIIIDCCCC").Returns("DCCCCXXXXVIIII");
                    yield return new TestCaseData("VIIIILXXXXI").Returns("LXXXXVIIIII");
                }
            }
        }
    }
}
