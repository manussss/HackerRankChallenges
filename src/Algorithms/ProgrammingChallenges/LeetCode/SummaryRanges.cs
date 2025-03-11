namespace ProgrammingChallenges.LeetCode;

public static class SummaryRanges
{
    /*
    You are given a sorted unique integer array nums.

    A range [a,b] is the set of all integers from a to b (inclusive).

    Return the smallest sorted list of ranges that cover all the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.

    Each range [a,b] in the list should be output as:

    "a->b" if a != b
    "a" if a == b

    Example 1:

    Input: nums = [0,1,2,4,5,7]
    Output: ["0->2","4->5","7"]
    Explanation: The ranges are:
    [0,2] --> "0->2"
    [4,5] --> "4->5"
    [7,7] --> "7" 
     */
    public static IList<string> GetSummaryRanges(int[] nums)
    {
        List<string> ranges = [];

        if (nums.Length == 0)
            return ranges;

        int start = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1] + 1)
            {
                if (start == i - 1)
                {
                    ranges.Add(nums[start].ToString());
                }
                else
                {
                    ranges.Add(nums[start] + "->" + nums[i - 1]);
                }
                start = i;
            }
        }

        if (start == nums.Length - 1)
        {
            ranges.Add(nums[start].ToString());
        }
        else
        {
            ranges.Add(nums[start] + "->" + nums[^1]);
        }

        return ranges;
    }
}
