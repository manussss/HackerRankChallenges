namespace ProgrammingChallenges.LeetCode;

public static class RemoveDuplicatesFromSortedArray
{
    /*
    arr = [1, 1, 2, 3, 3, 4, 5]

    1) Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place 
        such that each unique element appears only once. The relative order of the elements should be 
        kept the same. Then return the number of unique elements in nums. 
    
    1.1) remove duplicates in-place so each number appears only once
    2) start with an aux = 0 to count the number of unique elements
    3) iterate through 'nums' starting by 1 bc we will compare nums[i] with nums[aux]
    4) if they are different, increment aux position and assign nums[i] to nums[aux]
    5) since is already sorted, the smallest elements are on the left
    6) return aux + 1 bc we jumped on the first iteration
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
