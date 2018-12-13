using NUnit.Framework;
using RomanCalculator.Model;
using System.Collections;

namespace RomanCalculator.Tests
{
    [TestFixture]
    internal class SorterTests
    {
        [Test, TestCaseSource(typeof(SorterTestData), nameof(SorterTestData.UnsortedCases))]
        public string Sorting_by_weights_a_number(RomanNumber numberToSort) {
            return Sorter.SortByWeight(numberToSort);
        }

        private class SorterTestData
        {
            public static IEnumerable UnsortedCases
            {
                get
                {
                    yield return new TestCaseData(new RomanNumber("X")).Returns("X");
                    yield return new TestCaseData(new RomanNumber("III")).Returns("III");
                    yield return new TestCaseData(new RomanNumber("IDLCCXILM")).Returns("MDCCLLXII");
                    yield return new TestCaseData(new RomanNumber("VXVIIII")).Returns("XVVIIII");
                    yield return new TestCaseData(new RomanNumber("XXXXVIIIIDCCCC")).Returns("DCCCCXXXXVIIII");
                    yield return new TestCaseData(new RomanNumber("VIIIILXXXXI")).Returns("LXXXXVIIIII");
                }
            }
        }
    }
}
