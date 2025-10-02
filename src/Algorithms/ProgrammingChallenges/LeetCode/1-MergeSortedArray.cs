namespace ProgrammingChallenges.LeetCode;

public static class MergeSortedArray
{
    /*
    Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
    Output: [1,2,2,3,5,6]

    1) Merge nums1 and nums2 into a single array sorted in non-decreasing order 
    2) array1 is already ordered, just start from where it ends to add the items from array2
    3) start with an aux = 0
    4) when aux == array2Count, then break bc it means the next iteration the index will break
    5) order the array in-place
     */
    public static int[] Merge(int[] array1, int array1Count, int[] array2, int array2Count)
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

        return array1;
    }
}
