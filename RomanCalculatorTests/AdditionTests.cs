using NUnit.Framework;
using System.Collections;

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
        public void Adding_an_empty_number_to_a_non_empty_number_returns_the_non_empty_number()
        {
            var nonEmptyNumber = "I";
            var emptyNumber = "";

            var result = Addition.Sum(nonEmptyNumber, emptyNumber);

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

        [Test, TestCaseSource(typeof(AdditionTestData), nameof(AdditionTestData.AdditionTestCases))]
        public string Adding_two_random_numbers(string firstNumber, string secondNumber)
        {
            return Addition.Sum(firstNumber, secondNumber);
        }

        private class AdditionTestData
        {
            public static IEnumerable AdditionTestCases
            {
                get
                {
                    yield return new TestCaseData("I", "I").Returns("II");
                    yield return new TestCaseData("IV", "V").Returns("IX");
                    yield return new TestCaseData("XCIII", "VIII").Returns("CI");
                    yield return new TestCaseData("L", "L").Returns("C");
                    yield return new TestCaseData("MMM", "M").Returns("MMMM");
                    yield return new TestCaseData("C", "CM").Returns("M");
                    yield return new TestCaseData("CLXIX", "MMCMXLIX").Returns("MMMCXVIII");
                    yield return new TestCaseData("IIII", "XII").Returns("XVI");
                }
            }
        }
    }
}
