namespace ProgrammingChallenges.ManningAlgorithms.Recursion;

public static class SumArray
{
    public static int Sum(int[] numbers)
    {
        if (numbers.Length == 0)
            return 0;

        return numbers[0] + Sum(numbers[1..]);
    }
}