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

            var output = "b";
            Assert.AreEqual(expected, output);
        }
    }
}
