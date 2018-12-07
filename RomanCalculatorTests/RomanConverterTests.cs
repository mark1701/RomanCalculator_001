using NUnit.Framework;

namespace RomanCalculator.Tests
{
    internal class PositiviseNumberTests
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

    internal class NormaliseNumberTests
    {

        [Test]
        public void Normalise_empty_numeral()
        {
            var numberToConvert = "";
            var expectedConversion = "";

            var result = RomanConverter.NormaliseNumber(numberToConvert);

            Assert.AreEqual(expectedConversion, result);
        }

        [Test]
        public void Normalise_IV()
        {
            var numberToConvert = "IV";
            var expectedConversion = "IV";

            var result = RomanConverter.NormaliseNumber(numberToConvert);

            Assert.AreEqual(expectedConversion, result);
        }

        [Test]
        public void Normalise_IIII()
        {
            var numberToConvert = "IIII";
            var expectedConversion = "IV";

            var result = RomanConverter.NormaliseNumber(numberToConvert);

            Assert.AreEqual(expectedConversion, result);
        }

        [Test]
        public void Normalise_VIIII()
        {
            var numberToConvert = "VIIII";
            var expectedConversion = "IX";

            var result = RomanConverter.NormaliseNumber(numberToConvert);

            Assert.AreEqual(expectedConversion, result);
        }

        [Test]
        public void Normalise_XXXXVIIII()
        {
            var numberToConvert = "XXXXVIIII";
            var expectedConversion = "IL";

            var result = RomanConverter.NormaliseNumber(numberToConvert);

            Assert.AreEqual(expectedConversion, result);
        }

    }
}
