namespace ProgrammingChallenges.LeetCode;

public static class RemoveElement
{
    /*
    Input: nums = [3,2,2,3], val = 3
    Output: 2, nums = [2,2,_,_]

    1) Given an integer array nums and an integer val, remove all occurrences of val 
        in nums in-place. The order of the elements may be changed. Then return the number of elements in 
        nums which are not equal to val. 
    
    1.1) remove 'val' from 'nums' in-place
    2) loop through 'nums'
    2.1) for each num, if its value is != than val then assign this value to the val position
    3) set 'val' count to an aux starting at 0
    4) return count of 'val's
     */
    public static int GetElementsExcept(int[] nums, int val)
    {
        var aux = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[aux] = nums[i];
                aux++;
            }
        }

        return aux;
    }
}
