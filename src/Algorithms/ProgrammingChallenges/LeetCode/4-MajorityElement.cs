namespace ProgrammingChallenges.LeetCode;

public static class MajorityElement
{
    /*
    Given an array nums of size n, return the majority element.
    The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array. 
     */
    public static int GetMajorityElement(int[] nums)
    {
        var map = new Dictionary<int, int>();
        var majority = nums.Length / 2;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i]))
                map.Add(nums[i], 1);
            else
                map[nums[i]]++;
        }

        return map.FirstOrDefault(m => m.Value > majority).Key;
    }
}
