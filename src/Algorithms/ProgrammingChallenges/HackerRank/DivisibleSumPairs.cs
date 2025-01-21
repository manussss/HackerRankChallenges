namespace ProgrammingChallenges.HackerRank
{
    public static class DivisibleSumPairs
    {
        public static int GetNumberOfPairs(int arrayLength, int divisor, List<int> array)
        {
            var pairs = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if ((array[i] + array[j]) % divisor == 0)
                        pairs++;
                }
            }

            return pairs;
        }
    }
}
