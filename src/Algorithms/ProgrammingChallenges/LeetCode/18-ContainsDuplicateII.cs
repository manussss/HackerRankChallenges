namespace ProgrammingChallenges.LeetCode;

public static class ContainsDuplicateII
{
    /*
    1) Given an integer array nums and an integer k, return true 
        if there are two distinct indices i and j in the array such 
        that nums[i] == nums[j] and abs(i - j) <= k.

        Example 1:
        Input: nums = [1,2,3,1], k = 3
        Output: true
        
        Example 2:
        Input: nums = [1,0,1,1], k = 1
        Output: true

        Example 3:
        Input: nums = [1,2,3,1,2,3], k = 2
        Output: false

    2) create a map to store the number and its index in nums
    3) loop through nums
        3.1) try to get the value of nums[i] from the map and check if the current index (i)
            less the value [abs] is <= k, if both conditions are true, it means that the
            number exists in the map and its previous index - current index is <= k
        3.2) if the condition above its false, then add nums[i] to the map with the value
            of its index (i)
    4) otherwise return false
     */
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.TryGetValue(nums[i], out int value) && Math.Abs(i - value) <= k)
                return true;

            map[nums[i]] = i;
        }

        return false;
    }
}
