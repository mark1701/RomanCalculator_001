using NUnit.Framework;
using System.Collections;

namespace RomanCalculator.Tests
{
    [TestFixture]
    internal class SubtractiveNumbersTests
    {
        [Test, TestCaseSource(typeof(SubtractiveTestData), nameof(SubtractiveTestData.TestCases))]
        public string PositiviseNumber(string numberToConvert)
        {
            return Converter.PositiviseNumber(numberToConvert);
        }

        private class SubtractiveTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData("X").Returns("X");
                    yield return new TestCaseData("IV").Returns("IIII");
                    yield return new TestCaseData("XL").Returns("XXXX");
                    yield return new TestCaseData("CM").Returns("DCCCC");
                    yield return new TestCaseData("IL").Returns("XXXXVIIII");
                    yield return new TestCaseData("IL").Returns("XXXXVIIII");
                    yield return new TestCaseData("ID").Returns("CCCCLXXXXVIIII");
                    yield return new TestCaseData("XCIV").Returns("LXXXXIIII");
                    yield return new TestCaseData("MCLXXIV").Returns("MCLXXIIII");
                    yield return new TestCaseData("CXXXIX").Returns("CXXXVIIII");
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
            return Converter.NormaliseNumber(numberToConvert);
        }

        private class NormalisededData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData("").Returns("");
                    yield return new TestCaseData(" ").Returns(" ");
                    yield return new TestCaseData("X").Returns("X");
                    yield return new TestCaseData("IV").Returns("IV");
                    yield return new TestCaseData("IIII").Returns("IV");
                    yield return new TestCaseData("IIII").Returns("IV");
                    yield return new TestCaseData("VIIII").Returns("IX");
                    yield return new TestCaseData("XXXXVIIII").Returns("IL");
                    yield return new TestCaseData("LXXXXIIII").Returns("XCIV");
                    yield return new TestCaseData("MCLXXIIII").Returns("MCLXXIV");
                    yield return new TestCaseData("CXXXVIIII").Returns("CXXXIX");
                }
            }
        }
    }


}
