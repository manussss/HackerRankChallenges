namespace ProgrammingChallenges.HackerRank;

public static class SaveThePrisioner
{
    /*
    return the chair number of the prisoner to warn (the last chair)
     
    prisioners = 4
    sweets = 6
    chairNumberToBegin = 2

    []
    [2]
    [2, 3]
    [2, 3, 4] -> max prisioners
    [2, 3, 4, 1]
    [2, 3, 4, 1, 2]
    [2, 3, 4, 1, 2, 3] -> max sweets
    chair number to warn = 3 (last)



    prisioners = 5
    sweets = 2
    chairNumberToBegin = 1
    
    []
    [1]
    [1, 2]
    [1, 2, 3]
    [1, 2, 3, 4]
    [1, 2, 3, 4, 5]
    [1, 2, 3, 4, 5, 1]
    [1, 2, 3, 4, 5, 1, 2] -> max sweets = 2 (last)

    (1 + 2 - 1) % 5 = chair number 
     */
    public static int GetChairNumber(int prisioners, int sweets, int chairNumberToBegin)
    {
        var lastPrisoner = (chairNumberToBegin + sweets - 1) % prisioners;

        return lastPrisoner == 0 ? prisioners : lastPrisoner;
    }
}
