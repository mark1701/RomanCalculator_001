using System.Collections.Generic;
using System.Linq;

namespace RomanCalculator
{
    public static class Converter
    {
        private static readonly Dictionary<string, string> SubtractiveNumbersReplacements = new Dictionary<string, string> {
            {"IV","IIII"},
            {"IX","VIIII"},
            {"XL","XXXX"},
            {"XC","LXXXX"},
            {"CD","CCCC"},
            {"CM","DCCCC"},
            {"IL","XXXXVIIII"},
            {"IC","LXXXXVIIII"},
            {"XD","CCCCLXXXX"},
            {"XM","DCCCCLXXXX"},
            {"ID","CCCCLXXXXVIIII"},
            {"IM","DCCCCLXXXXVIIII"},
        };

        private static readonly Dictionary<string, string> PositivisedNumbersNormalisedForms = SubtractiveNumbersReplacements.ToDictionary(x => x.Value, x => x.Key);

        public static string PositiviseNumber(string number) {
            var positivisedNumber = number;

            foreach (var subtractiveNumber in SubtractiveNumbersReplacements.Keys) {
                positivisedNumber = positivisedNumber.Replace(subtractiveNumber, SubtractiveNumbersReplacements[subtractiveNumber]);
            }

            return positivisedNumber;
        }

        public static string NormaliseNumber(string number) {
            var normalisededNumber = number;
            var sortedPositivisedForms = PositivisedNumbersNormalisedForms.Keys.OrderByDescending(key => key.Length);

            foreach (var positivisedNumber in sortedPositivisedForms)
            {
                normalisededNumber = normalisededNumber.Replace(positivisedNumber, PositivisedNumbersNormalisedForms[positivisedNumber]);
            }

            return normalisededNumber;
        }


    }
}
