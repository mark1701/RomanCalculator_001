using System;
using System.Collections.Generic;

namespace RomanCalculator.Model
{
    public class RomanNumber
    {
        public RomanNumber(string number) {
            ComposingNumerals = new List<Type>();

            foreach (var c in number) {
                ComposingNumerals.Add(RomanNumerals.GetNumeral(c));
            }               
        }

        public List<Type> ComposingNumerals { get; }
    }
}
