﻿namespace ProgrammingChallenges.LeetCode;

public static class TwoSum
{
    /*
    1) Given an array of integers nums and an integer target, 
        return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and 
        you may not use the same element twice.
        You can return the answer in any order.
    2) loop through nums starting at index zero
        2.1) loop through nums starting at index zero + 1
        2.2) if nums[i] + nums[j] == target, then store and return the result
     */    
    public static int[] GetTwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                    return [i, j,];
            }
        }

        return [];
    }
}
