namespace RomanCalculator
{
    public static class Addition
    {
        public static string Sum(string firstAddend, string secondAddend) {
            var positivisedFirstAddend = Converter.PositiviseNumber(firstAddend);
            var positivisedSecondAddend = Converter.PositiviseNumber(secondAddend);

            var sortedResult = Sorter.SortByWeight(positivisedFirstAddend + positivisedSecondAddend);

            var normalisedResult = Converter.NormaliseNumber(sortedResult);

            return normalisedResult;
        }
    }
}
