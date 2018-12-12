using RomanCalculator.Model;

namespace RomanCalculator
{
    public static class Sorter
    {
        public static string SortByWeight(string numberToSort) {
            var sortedByDescendingWeightNumerals = Numerals.GetNumeralsByDescendingWeight();
            var sortedNumber = "";

            foreach (var numeral in sortedByDescendingWeightNumerals)
            {
                foreach (char element in numberToSort)
                {
                    if (Numerals.GetNumeral(element) == numeral)
                    {
                        sortedNumber += numeral.Name;
                    }
                }
            }

            return sortedNumber;
        }
    }
}
