namespace HackerRank.Challenges.Algorithms.Algorithms
{
    public static class BreakingTheRecords
    {
        public static List<int> GetRecords(List<int> scores)
        {
            var max = 0;
            var min = 0;
            var most = scores[0];
            var least = scores[0];

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] < least)
                {
                    min++;
                    least = scores[i];
                }
                else if (scores[i] > most)
                {
                    max++;
                    most = scores[i];
                }
            }

            return [max, min];
        }
    }
}