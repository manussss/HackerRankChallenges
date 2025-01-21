using System.Collections.Generic;

namespace ProgrammingChallenges.HackerRank;

/*
 find the minimum and maximum values that can be calculated by summing exactly four of the five integers
 
 find the max number and remove it to return the minimum
 find the min number and remove it to return the maximum

 Then return the respective minimum and maximum
 
 */
public static class MinMaxSum
{
    public static long[] GetMinMaxSum(List<int> list)
    {
        var max = list.Max();
        var min = list.Min();
        var sum = list.Sum(x => (long)x);

        return [sum - max, sum - min];
    }
}
