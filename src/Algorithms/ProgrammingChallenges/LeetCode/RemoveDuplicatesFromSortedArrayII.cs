namespace ProgrammingChallenges.LeetCode;

public static class RemoveDuplicatesFromSortedArrayII
{
    /*
    Given an integer array nums sorted in non-decreasing order, remove some duplicates in-place 
    such that each unique element appears at most twice. The relative order of the elements should be kept the same.

    Since it is impossible to change the length of the array in some languages, you must instead have 
    the result be placed in the first part of the array nums. More formally, if there are k elements 
    after removing the duplicates, then the first k elements of nums should hold the final result. 
    It does not matter what you leave beyond the first k elements. 

    [1, 1, 2, 2, 2, 3, 3, 4, 5]
    [1, 1, 2, 2, 3, 3, 4, 5]

     */
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2)
            return nums.Length;
        
        var aux = 2;

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[aux - 2])
            {
                nums[aux] = nums[i];
                aux++;
            }
        }

        return aux;
    }
}
