namespace ProgrammingChallenges.HackerRank;

public static class AVeryBigSum
{
    public static long GetAVeryBigSum(List<long> ar)
    {
        long sum = 0;

        foreach (var item in ar)
        {
            sum += item;
        }

        return sum;
    }
}
