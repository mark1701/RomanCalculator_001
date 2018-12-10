namespace RomanCalculator
{
    public static class Sorter
    {
        public static string SortByWeight(string numberToSort) {
            var sortedByWeightNumerals = new char[] { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            var sortedNumber = "";

            foreach (var numeral in sortedByWeightNumerals)
            {
                foreach (char element in numberToSort)
                {
                    if (element == numeral)
                    {
                        sortedNumber += numeral;
                    }
                }
            }

            return sortedNumber;
        }
    }
}
