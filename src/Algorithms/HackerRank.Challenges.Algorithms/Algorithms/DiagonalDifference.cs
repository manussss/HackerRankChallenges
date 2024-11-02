namespace HackerRank.Challenges.Algorithms.Algorithms;

public static class DiagonalDifference
{
    /*
    Given a square matrix, calculate the absolute difference between the sums of its diagonals.

    1 2 3
    4 5 6
    9 8 9

    1 + 5 + 9 = 15
    3 + 5 + 9 = 17

    15 - 17 = 2

    1. Iniciar em zero
    2. Obter o array 0 e elemento 0 (inicio)
    3. Obter o array 0 e elemento Count - 1 - 0 (inicio)

    4. Obter o array 1 e elemento 1 (meio)
    5. Obter o array 1 e elemento Count - 1 - 1 (meio)

    6. Obter o array 2 e elemento 2 (fim)
    7. Obter o array 2 e elemento Count - 1 - 2 (fim)

    */
    public static int GetDiagonalDifference(List<List<int>> arr)
    {
        int sumPrimaryDiagonal = 0;
        int sumSecondaryDiagonal = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            sumPrimaryDiagonal += arr[i][i];
            sumSecondaryDiagonal += arr[i][arr.Count - 1 - i];
        }

        return Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
    }
}
