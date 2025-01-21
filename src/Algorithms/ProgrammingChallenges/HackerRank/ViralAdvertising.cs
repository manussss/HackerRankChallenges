namespace ProgrammingChallenges.HackerRank;

public static class ViralAdvertising
{
    /*
    first they advertise it to 5 people
    1 day -> floor(5/2)      = 2   = 2
    2 day -> day1 + (day1/2) = 3   = 5
    3 day -> day2 + (day2/2) = 4   = 9
    4 day -> day3 + (day3/2) = 6   = 15
    5 day -> day4 + (day4/2) = 9   = 24
    6 day -> day5 + (day5/2) = 13  = 37
    7 day -> day6 + (day6/2) = 19  = 56
     */
    public static int GetCumulativeLikesAt(int dayNumberToReport)
    {
        if (dayNumberToReport == 1)
            return 2;

        double sum = 2;
        double dayBefore = 2;

        for (int i = 2; i <= dayNumberToReport; i++)
        {
            dayBefore += Math.Floor((double)dayBefore / 2);
            sum += dayBefore;
        }

        return (int)sum;
    }
}
