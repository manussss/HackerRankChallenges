﻿namespace ProgrammingChallenges.LeetCode;

public static class TwoSum
{
    /*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    You can return the answer in any order. 
     */
    public static int[] GetTwoSum(int[] nums, int target)
    {
        int[] result = [];

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result = [i, j];
                    return result;
                }
            }
        }

        return result;
    }
}
