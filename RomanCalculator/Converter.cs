using System.Collections.Generic;
using System.Linq;

namespace RomanCalculator
{
    public static class Converter
    {
        private static readonly Dictionary<string, string> PositivisedNumeral = new Dictionary<string, string> {
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

        private static readonly Dictionary<string, string> NormalisedNumerals = PositivisedNumeral.ToDictionary(x => x.Value, x => x.Key);

        public static string PositiviseNumber(string number) {
            if (PositivisedNumeral.ContainsKey(number)) {
                return PositivisedNumeral[number];
            }
            return number;
        }

        public static string NormaliseNumber(string number) {
            if (NormalisedNumerals.ContainsKey(number))
            {
                return NormalisedNumerals[number];
            }
            return number;
        }


    }
}
