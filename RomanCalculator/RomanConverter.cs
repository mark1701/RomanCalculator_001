using System.Collections.Generic;

namespace RomanCalculator
{
    public static class RomanConverter
    {
        private static readonly Dictionary<string, string> NegativeNumeralReplacements = new Dictionary<string, string> {
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

        public static string PositiviseNumber(string number) {
            if (NegativeNumeralReplacements.ContainsKey(number)) {
                return NegativeNumeralReplacements[number];
            }
            return number;
        }

        public static string NormaliseNumber(string number) {
            return number;
        }
    }
}
