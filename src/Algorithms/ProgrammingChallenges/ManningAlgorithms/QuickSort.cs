namespace ProgrammingChallenges.ManningAlgorithms;

/*
Sua velocidade depende do pivô escolhido

[4, 3, 2, 1]


*/
public static class QuickSort
{
    public static void Sort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);

            Sort(array, left, pivotIndex - 1);
            Sort(array, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++; 
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);

        return i + 1;
    }

    private static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}