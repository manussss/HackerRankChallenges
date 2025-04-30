namespace ProgrammingChallenges.ManningAlgorithms;

/*
Sua velocidade depende do pivô escolhido

[4, 3, 2, 1]

1 - faça a partição, para deixar os menores que pivotIndex à esquerda e os maiores à direita
2 - Sort do inicio ao pivotIndex -1
3 - Sort do pivotIndex + 1 a direita
4 - junte tudo e o array estará ordenado
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
        (array[b], array[a]) = (array[a], array[b]);
    }
}