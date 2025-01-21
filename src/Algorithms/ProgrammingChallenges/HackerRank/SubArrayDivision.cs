namespace ProgrammingChallenges.HackerRank
{
    public static class SubArrayDivision
    {
        public static int GetChocolateSquare(List<int> chocolateSegment, int daySum, int monthLength)
        {
            var segments = 0;

            for (int i = 0; monthLength <= chocolateSegment.Count; i++)
            {
                if (chocolateSegment[i..monthLength].Sum() == daySum)
                    segments++;

                monthLength++;
            }

            return segments;
        }
    }
}
