namespace ProgrammingChallenges.LeetCode;

public static class MajorityElement
{
    /*
    1) Given an array nums of size n, return the majority element.
        The majority element is the element that appears more than ⌊n / 2⌋ times. 
        You may assume that the majority element always exists in the array. 
    2) you can create a dic to store the num and the number of times it exists
    3) iterate through nums
        if map doest not contains key, add it with 1 count
        if it contains, increment the count
    4) return the key of the item on the map with the count > than majority
     */
    public static int GetMajorityElement(int[] nums)
    {
        var majority = nums.Length / 2;
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i]))
                map.Add(nums[i], 1);
            else
                map[nums[i]]++;
        }

        return map.First(m => m.Value > majority).Key;
    }
}
