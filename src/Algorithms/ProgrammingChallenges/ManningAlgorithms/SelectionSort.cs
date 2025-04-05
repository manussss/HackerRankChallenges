namespace ProgrammingChallenges.ManningAlgorithms;

/*
O(N x N) ou O(Nˆ2)
*/
public static class SelectionSort
{
    public static int[] GetSelectionSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            var min = i;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[min] > numbers[j])
                    min = j;
            }

            var aux = numbers[i];
            numbers[i] = numbers[min];
            numbers[min] = aux;
        }

        return numbers;
    }
}