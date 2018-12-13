using System;
using System.Collections.Generic;

namespace RomanCalculator.Model
{
    internal static class RomanNumerals
    {
        internal class I { }
        internal class V { }
        internal class X { }
        internal class L { }
        internal class C { }
        internal class D { }
        internal class M { }

        private static readonly Dictionary<char, Type> _numeralsMapper = new Dictionary<char, Type> {
            {'I',typeof(I)},
            {'V',typeof(V)},
            {'X',typeof(X)},
            {'L',typeof(L)},
            {'C',typeof(C)},
            {'D',typeof(D)},
            {'M',typeof(M)}
        };

        internal static Type GetNumeral(char symbol) {
            return _numeralsMapper[symbol];
        }

        internal static List<Type> GetNumeralsByDescendingWeight() {
            return new List<Type> {typeof(M), typeof(D), typeof(C), typeof(L), typeof(X), typeof(V), typeof(I)};
        }
    }
}
