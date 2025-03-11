namespace ProgrammingChallenges.LeetCode;

public static class ContainsDuplicateII
{
    /*
    Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

    Example 1:

    Input: nums = [1,2,3,1], k = 3
    Output: true
    Example 2:

    Input: nums = [1,0,1,1], k = 1
    Output: true
    Example 3:

    Input: nums = [1,2,3,1,2,3], k = 2
    Output: false 
     */
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; (j < nums.Length && j <= i + k); j++) // garantir que o índice j não ultrapasse o limite do array nem a distância máxima permitida entre os índices i e j (definida por k)
            {
                if (nums[i] == nums[j] && Math.Abs(i - j) <= k)
                    return true;
            }
        }

        return false;
    }
}
