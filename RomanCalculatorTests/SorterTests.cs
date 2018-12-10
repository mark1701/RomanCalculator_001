using NUnit.Framework;
using System.Collections;

namespace RomanCalculator.Tests
{
    [TestFixture]
    internal class SorterTests
    {
        [Test, TestCaseSource(typeof(SorterTestData), nameof(SorterTestData.UnsortedCases))]
        public string Sorting_by_weights_a_number(string numberToSort) {
            return Sorter.SortByWeight(numberToSort);
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
