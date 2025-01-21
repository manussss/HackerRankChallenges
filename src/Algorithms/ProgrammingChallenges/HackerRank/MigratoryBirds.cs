namespace ProgrammingChallenges.HackerRank
{
    public static class MigratoryBirds
    {
        public static int GetBirdsFrequency(List<int> birdsIds)
        {
            return birdsIds
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .First()
                .Key;
        }
    }
}
