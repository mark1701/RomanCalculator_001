﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanCalculator
{
    public static class Converter
    {
        public static string PositiviseNumber(string number) {
            var positivisedNumber = number;

            foreach (var subtractiveNumber in ConversionSupportData.SubtractiveNumbersReplacements.Keys) {
                positivisedNumber = positivisedNumber.Replace(subtractiveNumber, ConversionSupportData.SubtractiveNumbersReplacements[subtractiveNumber]);
            }

            return positivisedNumber;
        }

        public static string NormaliseNumber(string number) {
            var normalisededNumber = number;

            //first check if there are numbers we can already assemble
            foreach (var compoundForm in ConversionSupportData.NumeralsComposition) {
                normalisededNumber = normalisededNumber.Replace(compoundForm.Item1, compoundForm.Item2);
            }

            var sortedPositivisedForms = ConversionSupportData.PositivisedNumbersNormalisedForms.Keys.OrderByDescending(key => key.Length);

            foreach (var positivisedNumber in sortedPositivisedForms)
            {
                normalisededNumber = normalisededNumber.Replace(positivisedNumber, ConversionSupportData.PositivisedNumbersNormalisedForms[positivisedNumber]);
            }

            return normalisededNumber;
        }

        private static class ConversionSupportData {

            internal static readonly Tuple<string, string>[] NumeralsComposition = new Tuple<string, string>[] {
                Tuple.Create("IIIII","V"),
                Tuple.Create("VV","X"),
                Tuple.Create("XXXXX","L"),
                Tuple.Create("LL","C"),
                Tuple.Create("CCCCC","D"),
                Tuple.Create("DD","M")
            };

            internal static readonly Dictionary<string, string> SubtractiveNumbersReplacements = new Dictionary<string, string> {
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

            internal static readonly Dictionary<string, string> PositivisedNumbersNormalisedForms = SubtractiveNumbersReplacements.ToDictionary(x => x.Value, x => x.Key);
        }
    }
}
