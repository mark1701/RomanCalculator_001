using NUnit.Framework;
using System.Collections;

namespace RomanCalculator.Tests
{
    [TestFixture]
    internal class PositiviseNumberTests
    {
        [Test, TestCaseSource(typeof(PositivisedData), nameof(PositivisedData.TestCases))]
        public string PositiviseNumber(string numberToConvert)
        {
            return RomanConverter.PositiviseNumber(numberToConvert);
        }

        private class PositivisedData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData("IV").Returns("IIII");
                    yield return new TestCaseData("XL").Returns("XXXX");
                    yield return new TestCaseData("CM").Returns("DCCCC");
                    yield return new TestCaseData("IL").Returns("XXXXVIIII");
                    yield return new TestCaseData("IL").Returns("XXXXVIIII");
                    yield return new TestCaseData("ID").Returns("CCCCLXXXXVIIII");
                }
            }
        }
    }

    [TestFixture]
    internal class NormaliseNumberTests
    {
        [Test, TestCaseSource(typeof(NormalisededData), nameof(NormalisededData.TestCases))]
        public string NormaliseNumber(string numberToConvert)
        {
            return RomanConverter.NormaliseNumber(numberToConvert);
        }

        private class NormalisededData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData("").Returns("");
                    yield return new TestCaseData(" ").Returns(" ");
                    yield return new TestCaseData("IV").Returns("IV");
                    yield return new TestCaseData("IIII").Returns("IV");
                    yield return new TestCaseData("IIII").Returns("IV");
                    yield return new TestCaseData("VIIII").Returns("IX");
                    yield return new TestCaseData("XXXXVIIII").Returns("IL");
                }
            }
        }
    }
}
