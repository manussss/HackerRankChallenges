namespace ProgrammingChallenges.LeetCode;

public static class MergeSortedArray
{
    /*
    Merge nums1 and nums2 into a single array sorted in non-decreasing order
    
    Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
    Output: [1,2,2,3,5,6]
     */
    public static void Merge(int[] array1, int array1Count, int[] array2, int array2Count)
    {
        var aux = 0;

        for (int i = array1Count; i < array1.Length; i++)
        {
            array1[i] = array2[aux];
            aux++;

            if (aux == array2Count)
                break;
        }

        Array.Sort(array1);
    }
}
