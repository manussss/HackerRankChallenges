namespace ProgrammingChallenges.LeetCode;

public static class MajorityElement
{
    /*
    Given an array nums of size n, return the majority element.
    The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array. 
     */
    public static int GetMajorityElement(int[] nums)
    {
        return nums.GroupBy(x => x).First(x => x.Count() > (nums.Length / 2)).Key;
    }
}
