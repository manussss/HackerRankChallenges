namespace ProgrammingChallenges.HackerRank;

public static class CountingValleys
{
    /*
    An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly 'steps'
    steps, for every step it was noted if it was an uphill, U , or a downhill, D step. Hikes always start and end at sea level, 
    and each step up or down represents a 1 unit change in altitude. We define the following terms:

    - A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
    - A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
    - Given the sequence of up and down steps during a hike, find and print the number of valleys walked through. 

    Cada vez que você estava abaixo do nível do mar e subiu para o nível 0 novamente, quer dizer que você saiu de um vale

     */
    public static int GetCountingValleys(int steps, string path)
    {
        var valley = 0;
        var level = 0;

        foreach (var step in path)
        {
            var levelBefore = level;

            if (step == 'U')
                level += 1;
            else if (step == 'D')
                level -= 1;

            if (levelBefore < 0 && level == 0) valley++;
        }

        return valley;
    }
}
