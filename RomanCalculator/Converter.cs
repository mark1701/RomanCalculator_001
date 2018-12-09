using System.Collections.Generic;
using System.Linq;

namespace RomanCalculator
{
    public static class Converter
    {
        private static readonly Dictionary<string, string> PositivisedNumbers = new Dictionary<string, string> {
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

        private static readonly Dictionary<string, string> NormalisedNumbers = PositivisedNumbers.ToDictionary(x => x.Value, x => x.Key);

        public static string PositiviseNumber(string number) {
            var positivisedNumber = "";
            int i = 0;

            while (i <= number.Length - 2) {

                var potentialNegativeCombination = number.Substring(i, 2);

                if (PositivisedNumbers.ContainsKey(potentialNegativeCombination))
                {
                    positivisedNumber += PositivisedNumbers[potentialNegativeCombination];
                    i = i + 2;
                    continue;
                } 
                positivisedNumber += number.Substring(i, 1);
                i++;
            }

            return string.IsNullOrEmpty(positivisedNumber) ? number : positivisedNumber;
        }

        public static string NormaliseNumber(string number) {
            if (NormalisedNumbers.ContainsKey(number))
            {
                return NormalisedNumbers[number];
            }
            return number;
        }


    }
}
