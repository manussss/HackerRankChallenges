namespace ProgrammingChallenges.HackerRank;

public static class TheHurdleRace
{
    /*
    get the max height to jump
    if max = natural or max - natural < 0, then return 0
    else return max to jump - natural
     */
    public static int GetPoisonsAmount(int naturalHeight, List<int> heightsToJump)
    {
        var maxHeightToJump = heightsToJump.Max();

        return (maxHeightToJump == naturalHeight || maxHeightToJump - naturalHeight < 0) ? 0 : maxHeightToJump - naturalHeight;
    }
}
