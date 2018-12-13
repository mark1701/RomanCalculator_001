using RomanCalculator.Model;

namespace RomanCalculator
{
    public static class Sorter
    {
        public static string SortByWeight(RomanNumber numberToSort) {
            var sortedByDescendingWeightNumerals = RomanNumerals.GetNumeralsByDescendingWeight();

            var sortedNumber = "";

            foreach (var numeral in sortedByDescendingWeightNumerals)
            {
                foreach (var element in numberToSort.ComposingNumerals)
                {
                    if (element == numeral)
                    {
                        sortedNumber += numeral.Name;
                    }
                }
            }

            return sortedNumber;
        }
    }
}
