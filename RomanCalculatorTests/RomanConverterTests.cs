using NUnit.Framework;

namespace RomanCalculator.Tests
{
    internal class PositiviseTests
    {
        [Test]
        public void Positivise_IV()
        {
            var numberToConvert = "IV";
            var expectedConversion = "IIII";

            var result = RomanConverter.PositiviseNumber(numberToConvert);

            Assert.AreEqual(expectedConversion, result);
        }

        [Test]
        public void Positivise_IX()
        {
            var numberToConvert = "IX";
            var expectedConversion = "VIIII";

            var result = RomanConverter.PositiviseNumber(numberToConvert);

            Assert.AreEqual(expectedConversion, result);
        }

        [Test]
        public void Positivise_IL()
        {
            var numberToConvert = "IL";
            var expectedConversion = "XXXXVIIII";

            var result = RomanConverter.PositiviseNumber(numberToConvert);

            Assert.AreEqual(expectedConversion, result);
        }

    }
}
