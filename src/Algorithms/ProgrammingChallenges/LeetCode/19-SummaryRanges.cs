namespace ProgrammingChallenges.LeetCode;

public static class SummaryRanges
{
    /*
    1) You are given a sorted unique integer array nums.
        A range [a,b] is the set of all integers from a to b (inclusive).
        Return the smallest sorted list of ranges that cover all the numbers 
        in the array exactly. That is, each element of nums is covered by exactly 
        one of the ranges, and there is no integer x such that x is in one of the ranges 
        but not in nums.

        Each range [a,b] in the list should be output as:

        "a->b" if a != b
        "a" if a == b

        Example 1:

        Input:  [0, 1, 2, 4, 5, 7]
        Output: ["0->2","4->5","7"]
        Explanation: The ranges are:
        [0,2] --> "0->2" (breaks bc there is no 3)
        [4,5] --> "4->5" (breaks bc there is no 6)
        [7,7] --> "7" 

    2) create a <string> list to store the ranges
    3) check if nums length is equals zero, if true, then return empty list
    4) create a variable 'start' = 0, this var stores where the index in 'nums'
        should be placed in the array
    5) loop through nums starting at 1
        5.1) if nums[i] is different than the number that should be in this 
            index (nums[i-1]+1) (reminder that the array is sorted), then:
            5.1.1) if 'start' equals i-1, then add nums[start] (it means that is just one
                number to be added)
            5.2.2) else add nums[start] + arrow + nums[i - 1]
            5.3.3) assign start = i
    6) check if 'start' == nums length - 1 (it means you're at the end of the array)
        6.1) if true, add nums[start] to 'ranges''
        6.2) else, it means that are more numbers to be added, add
            nums[start] + arrow + nums[ˆ1]
    7) return ranges
    */
    public static IList<string> GetSummaryRanges(int[] nums)
    {
        List<string> ranges = [];

        if (nums.Length == 0)
            return ranges;

        var start = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1] + 1)
            {
                if (start == i - 1)
                    ranges.Add(nums[start].ToString());
                else
                    ranges.Add(nums[start] + "->" + nums[i - 1]);

                start = i;
            }
        }

        if (start == nums.Length - 1)
            ranges.Add(nums[start].ToString());
        else
            ranges.Add(nums[start] + "->" + nums[^1]);

        return ranges;
    }
}
