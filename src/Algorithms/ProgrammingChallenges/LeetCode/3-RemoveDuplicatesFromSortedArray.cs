namespace ProgrammingChallenges.LeetCode;

public static class RemoveDuplicatesFromSortedArray
{
    /*
    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place 
    such that each unique element appears only once. The relative order of the elements should be 
    kept the same. Then return the number of unique elements in nums. 

    se length == 0, retorna
    i = 1
    aux = 0

    -> aux = 0
    -> sortedArray

    arr = [1, 1, 2, 3, 3, 4, 5]
     */
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        var aux = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[aux])
            {
                aux++;
                nums[aux] = nums[i];
            }
        }

        return aux + 1;
    }
}
