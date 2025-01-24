namespace ProgrammingChallenges.LeetCode;

public static class RemoveDuplicatesFromSortedArray
{
    /*
    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place 
    such that each unique element appears only once. The relative order of the elements should be 
    kept the same. Then return the number of unique elements in nums. 

    arr = [1, 1, 2, 3, 3, 4, 5]

    se length == 0, retorna
    j = 1
    aux = 0

    1 iteration) 1(pos 1) != 1 (pos 0), nao entao continua
    2 iteration) 2(pos 2) != 1 (pos 0), sim entao aux++ E nums[1] (1) = nums[2] (2)
    3 iteration) 3(pos 3) != 2 (pos 1), sim entao aux++ E nums[2] (2) = nums[3] (3)
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
