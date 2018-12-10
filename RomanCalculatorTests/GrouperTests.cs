using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace RomanCalculator.Tests
{
    [TestFixture]
    internal class SorterTests
    {
        [Test]
        public void Stub() {
            //output: a string containing all occuring numerals sorted by weight
            //a roman number in positive notation
            var input = "VIIIILXXXXI";
            var expected = "LXXXXVIIIII";

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

            var output = result;
            Assert.AreEqual(expected, output);
        }
    }
}
